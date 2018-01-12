using System;
using System.Diagnostics;
using AdoBankingSystem.DAL.DAOs;
using AdoBankingSystem.Shared.DTOs;
using AdoBankingSystem.Shared.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdoBankingSystem.UnitTests
{
    [TestClass]
    public class DALTests
    {
        [TestMethod]
        public void BankClientDao_Create()
        {
            // Arrange
            BankClientDto bankClientDto = 
                new BankClientDto("Test", "Test", "Test", "Test", "Test");

            bankClientDto.Id = "2222";

            BankClientDao bankClientDao =
                new BankClientDao();

            // Act
            string result = bankClientDao.Create(bankClientDto);

            // Assert
            Assert.IsTrue(bankClientDto.Id == result);
        }

        [TestMethod]
        public void CurrentSessionDao_Create()
        {
            CurrentSessionDto dto = new CurrentSessionDto()
            {
                UserId = "1111",
                LastOperationTime = DateTime.Now,
                SignInTime = DateTime.Now,
                EntityStatus = EntityStatusType.IsActive,
                CreatedTime = DateTime.Now
            };

            CurrentSessionDao dao = new CurrentSessionDao();
            dao.Create(dto);
        }

        [TestMethod]
        public void CurrentSessionDao_Read()
        {
            CurrentSessionDao dao = new CurrentSessionDao();
            var result = dao.Read();

            foreach (var item in result)
            {
                Debug.WriteLine(item.ToString());
            }
        }

        [TestMethod]
        public void CurrentSessionDao_Update()
        {
            CurrentSessionDto dto = new CurrentSessionDto()
            {
                Id = Guid.NewGuid().ToString(),
                UserId = "1111",
                LastOperationTime = DateTime.Now,
                SignInTime = DateTime.Now,
                EntityStatus = EntityStatusType.IsActive,
                CreatedTime = DateTime.Now,
                
            };

            CurrentSessionDao dao = new CurrentSessionDao();
            dao.Create(dto);
            dto.EntityStatus = EntityStatusType.IsBlocked;
            dao.Update(dto);
            Assert.IsTrue(dao.Read(dto.Id).EntityStatus == EntityStatusType.IsBlocked);
        }

        [TestMethod]
        public void CurrentSessionDao_Delete()
        {
            CurrentSessionDto dto = new CurrentSessionDto()
            {
                Id = Guid.NewGuid().ToString(),
                UserId = "1111",
                LastOperationTime = DateTime.Now,
                SignInTime = DateTime.Now,
                EntityStatus = EntityStatusType.IsActive,
                CreatedTime = DateTime.Now,

            };

            CurrentSessionDao dao = new CurrentSessionDao();
            dao.Create(dto);
            dao.Remove(dto.Id);
            Assert.IsNull(dao.Read(dto.Id));
        }

        [TestMethod]
        public void CreateBankManager()

        {

            BankManagerDao bankManagerDAO = new BankManagerDao();

            BankManagerDto bankManagerDto = new BankManagerDto()

            {

                FirstName = "Aibek",

                LastName = "Shulembekov",

                Email = "aiba1805@gmail.com",

                CreatedTime = DateTime.Now,

                ApplicationClientType = ApplicationClientType.BankManager,

                EntityStatus = EntityStatusType.IsActive,

                PasswordHash = "123",

            };

            bankManagerDto.Id = ApplicationUserIdGenerator.GenerateUniqueId(

                bankManagerDto.FirstName, bankManagerDto.LastName,

                bankManagerDto.ApplicationClientType);

            Assert.IsTrue(bankManagerDto.Id == bankManagerDAO.Create(bankManagerDto));

        }

        [TestMethod]
        public void DeleteBankManager()

        {

            BankManagerDao bankManagerDAO = new BankManagerDao();

            BankManagerDto bankManagerDto = new BankManagerDto()

            {

                FirstName = "Serik",

                LastName = "Shulembekov",

                Email = "serik68@gmail.com",

                CreatedTime = DateTime.Now,

                ApplicationClientType = ApplicationClientType.BankManager,

                EntityStatus = EntityStatusType.IsActive,

                PasswordHash = "123",

            };

            bankManagerDto.Id = ApplicationUserIdGenerator.GenerateUniqueId(

                bankManagerDto.FirstName, bankManagerDto.LastName,

                bankManagerDto.ApplicationClientType);

            bankManagerDAO.Create(bankManagerDto);

            bankManagerDAO.Remove(bankManagerDto.Id);

            Assert.IsNull(bankManagerDAO.Read(bankManagerDto.Id));

        }

        [TestMethod]

        public void UpdateBankManager()

        {

            BankManagerDao bankManagerDAO = new BankManagerDao();

            BankManagerDto bankManagerDto = new BankManagerDto()

            {

                FirstName = "Arecr",

                LastName = "Frers",

                Email = "AreFres@gmail.com",

                CreatedTime = DateTime.Now,

                ApplicationClientType = ApplicationClientType.BankManager,

                EntityStatus = EntityStatusType.IsActive,

                PasswordHash = "123",

            };

            bankManagerDto.Id = ApplicationUserIdGenerator.GenerateUniqueId(

                bankManagerDto.FirstName, bankManagerDto.LastName,

                bankManagerDto.ApplicationClientType);

            bankManagerDAO.Create(bankManagerDto);

            bankManagerDto.LastName = "Reded";

            string result = bankManagerDAO.Update(bankManagerDto);

            Assert.IsTrue(result == "1");

        }

        [TestMethod]

        public void DeleteBankClient()
        {

            BankClientDao bankManagerDAO = new BankClientDao();

            BankClientDto bankManagerDto = new BankClientDto()

            {

                FirstName = "Serik",

                LastName = "Shulembekov",

                Email = "serik68@gmail.com",

                CreatedTime = DateTime.Now,

                ApplicationClientType = ApplicationClientType.BankClient,

                EntityStatus = EntityStatusType.IsActive,

                PasswordHash = "123",

            };

            bankManagerDto.Id = ApplicationUserIdGenerator.GenerateUniqueId(

                bankManagerDto.FirstName, bankManagerDto.LastName,

                bankManagerDto.ApplicationClientType);

            bankManagerDAO.Create(bankManagerDto);

            bankManagerDAO.Remove(bankManagerDto.Id);

            Assert.IsNull(bankManagerDAO.Read(bankManagerDto.Id));

        }

        [TestMethod]
        public void UpdateBankClient()
        {

            BankClientDao bankManagerDAO = new BankClientDao();

            BankClientDto bankManagerDto = new BankClientDto()

            {

                FirstName = "Arecr",

                LastName = "Frers",

                Email = "AreFres@gmail.com",

                CreatedTime = DateTime.Now,

                ApplicationClientType = ApplicationClientType.BankClient,

                EntityStatus = EntityStatusType.IsActive,

                PasswordHash = "123",

            };

            bankManagerDto.Id = ApplicationUserIdGenerator.GenerateUniqueId(

                bankManagerDto.FirstName, bankManagerDto.LastName,

                bankManagerDto.ApplicationClientType);

            bankManagerDAO.Create(bankManagerDto);

            bankManagerDto.LastName = "Reded";

            string result = bankManagerDAO.Update(bankManagerDto);

            Assert.IsTrue(result == "1");

        }

        [TestMethod]
        public void ReadBankManager()

        {
            BankManagerDao bankManagerDAO = new BankManagerDao();

            var res = bankManagerDAO.Read();
            foreach (var item in res)
            {
                Debug.WriteLine(item.ToString());
            }
        }

        [TestMethod]
        public void ReadBankClient()

        {
            BankClientDao bankManagerDAO = new BankClientDao();

            var res = bankManagerDAO.Read();
            foreach (var item in res)
            {
                Debug.WriteLine(item.ToString());
            }
        }

        [TestMethod]
        public void TransactionDao_Create()
        {
            TransactionDao transactionDao = new TransactionDao();
            string idToSet = Guid.NewGuid().ToString();
            string result = transactionDao.Create(new TransactionDto()
            {
                SenderId = "Zeus",
                ReceiverId = "Drow Ranger",
                TransactionAmount = 6200,
                TransactionType = TransactionType.ClientToClientTransaction,
                TransactionTime = DateTime.Now,
                EntityStatus = EntityStatusType.IsActive,
                CreatedTime = DateTime.Now,
                Id = idToSet
            });

            Assert.IsTrue(result == idToSet);
        }

        [TestMethod]
        public void TransactionDao_Update()
        {
            TransactionDao transactionDao = new TransactionDao();
            string idToSet = Guid.NewGuid().ToString();
            var transactionDto = new TransactionDto()
            {
                SenderId = "Zeus",
                ReceiverId = "Drow Ranger",
                TransactionAmount = 6200,
                TransactionType = TransactionType.ClientToClientTransaction,
                TransactionTime = DateTime.Now,
                EntityStatus = EntityStatusType.IsActive,
                CreatedTime = DateTime.Now,
                Id = idToSet
            };
            string result = transactionDao.Create(transactionDto);
            transactionDto.EntityStatus = EntityStatusType.IsBlocked;
            transactionDao.Update(transactionDto);
            Assert.IsTrue(transactionDao.Read(transactionDto.Id).EntityStatus == EntityStatusType.IsBlocked);
        }

        [TestMethod]
        public void TransactionDao_Delete()
        {
            TransactionDao bankManagerDAO = new TransactionDao();

            var transactionDto = new TransactionDto()
            {
                SenderId = "Zeus",
                ReceiverId = "Drow Ranger",
                TransactionAmount = 6200,
                TransactionType = TransactionType.ClientToClientTransaction,
                TransactionTime = DateTime.Now,
                EntityStatus = EntityStatusType.IsActive,
                CreatedTime = DateTime.Now,
                Id = Guid.NewGuid().ToString()
            };
           

            bankManagerDAO.Create(transactionDto);

            bankManagerDAO.Remove(transactionDto.Id);

            Assert.IsNull(bankManagerDAO.Read(transactionDto.Id));
        }

        [TestMethod]
        public void ReadTransaction()

        {
            TransactionDao bankManagerDAO = new TransactionDao();

            var res = bankManagerDAO.Read();
            foreach (var item in res)
            {
                Debug.WriteLine(item.ToString());
            }
        }
    }
}
