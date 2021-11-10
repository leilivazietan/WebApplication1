using ExcelDataReader;
using System.Collections.Generic;
using System.IO;
using WebApplication1.Contracts;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class UserInfoReader : IUserInfoReader
    {
        private readonly string filePath = @"C:\Users\Fujitsu\Desktop\user.xlsx";
        public List<User> ReadFromExecl()
        {
            List<User> users = new List<User>();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {

                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {

                    while (reader.Read())
                    {
                        var user = new User()

                        {
                            FullName = reader.GetValue(0).ToString(),
                            Code = reader.GetValue(1).ToString(),
                            Email = reader.GetValue(2).ToString(),
                            Password = reader.GetValue(3).ToString()


                        };
                        users.Add(user);

                    }

                }
            }
            return users;
        }
    }
}
