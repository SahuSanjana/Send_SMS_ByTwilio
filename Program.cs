using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace Send_SMS_ByTwilio
{
    class Program
    {
      


    
        static void Main(string[] args)
        {
            try
            {
                var accountSid = "ACe705349d61d3fb0688f44d2fb70970dc";
                var authToken = "a7a2f75853503e5dee7ccea1527cc8ea";
                TwilioClient.Init(accountSid, authToken);

                var messageOptions = new CreateMessageOptions(
                  new PhoneNumber("+918435943098"));
                messageOptions.From = new PhoneNumber("+13102997487");
                messageOptions.Body = "Love you..";


                var message = MessageResource.Create(messageOptions);
                Console.WriteLine(message.Body);
            }
            catch (Exception ex)
            {

                
            }
        }
    }
}

