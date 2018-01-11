using AdoBankingSystem.BLL.Interfaces;
using AdoBankingSystem.BLL.Services;
using AdoBankingSystem.ClientUI.Base;
using AdoBankingSystem.Shared.DTOs;
using AdoBankingSystem.Shared.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoBankingSystem.ClientUI.Forms
{
    public partial class RegistrationWindow : Form
    {
        private OfflineModeStorageService _offlineDataPublisher;
        private RabbitMqBusService _onlineDataPublisher;
        private ApplicationClientService _applicationClientService;
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string firstName = textBox2.Text;
            string lastName = textBox1.Text;
            string password = passwordTextBox.Text;
            string email = emailTextBox.Text;
            if (!(String.IsNullOrEmpty(firstName)
                && string.IsNullOrEmpty(lastName)
                && string.IsNullOrEmpty(password)
                && string.IsNullOrEmpty(email)))
            {
                BankClientDto bankClientDto = new BankClientDto()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    ApplicationClientType = ApplicationClientType.BankClient,
                    CreatedTime = DateTime.Now,
                    Email = email,
                    EntityStatus = EntityStatusType.IsActive,
                    PasswordHash = password
                };

                if (ConnectionManagerUtil.IsConnectionAvailable())
                {
                    var pastData = _offlineDataPublisher.GetAllPastData<BankClientDto>();
                    if (pastData.Count > 0)
                    {
                        var sortedData = pastData.OrderBy(p => p.CreatedTime);
                        foreach (var item in sortedData)
                        {
                            _onlineDataPublisher.PublishMessageToStorage(item);
                        }
                    }

                    _onlineDataPublisher.PublishMessageToStorage(bankClientDto);
                }
                else _offlineDataPublisher.PublishMessageToStorage(bankClientDto);
            }
        }
        public RegistrationWindow()
        {
            _onlineDataPublisher = new RabbitMqBusService();
            _offlineDataPublisher = new OfflineModeStorageService();
            _applicationClientService = new ApplicationClientService();
            InitializeComponent();
        }

    }
}
