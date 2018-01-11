using AdoBankingSystem.BLL.Services;
using AdoBankingSystem.Shared.DTOs;
using AdoBankingSystem.Shared.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoBankingSystem.ClientUI.Forms
{
    public partial class TransactionForm : Form
    {
        private OfflineModeStorageService _offlineDataPublisher;
        private RabbitMqBusService _onlineDataPublisher;
        public TransactionForm()
        {
            _offlineDataPublisher = new OfflineModeStorageService();
            _onlineDataPublisher = new RabbitMqBusService();
            InitializeComponent();
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            string senderId = fromTextBox.Text;
            string receiverId = toTextBox.Text;
            decimal amount = amountNumericUpDown.Value;
            if(!(string.IsNullOrEmpty(senderId) &&
                string.IsNullOrEmpty(receiverId)) && 
                amount > 0){
                TransactionDto transactionDto = new TransactionDto()
                {
                    Id = Guid.NewGuid().ToString(),
                    CreatedTime = DateTime.Now,
                    EntityStatus = EntityStatusType.IsActive,
                    SenderId = senderId,
                    ReceiverId = receiverId,
                    TransactionAmount = amount,
                    TransactionTime = DateTime.Now,
                    TransactionType = TransactionType.ClientToClientTransaction
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

                    _onlineDataPublisher.PublishMessageToStorage(transactionDto);
                }
                else _offlineDataPublisher.PublishMessageToStorage(transactionDto);
            }
        }
    }
}
