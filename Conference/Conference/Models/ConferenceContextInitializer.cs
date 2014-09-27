using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Conference.Models
{
    public class ConferenceContextInitializer : DropCreateDatabaseAlways<ConferenceContext>
    {
        protected override void Seed(ConferenceContext context)
        {
            context.Sessions.Add
                    (
                        new Session()
                            {
                                Title = "This is title I am saddam",
                                Abstract = "Hi this is abstract . this is nothing but a description . bla bla bla ",
                                Speaker = context.Speakers.Add
                                    (
                                        new Speaker()
                                            {
                                                Name = "Saddam Hossain",
                                                EmailAddress = "saddam@gmail.com"
                                            }
                                    )
                            }
                    );
            context.SaveChanges();
        }
    }
}