using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_del
{
    class Publisher
    {
        //private SendEmails subscribers;


        //public void Subscribe(SendEmails new_subscriber) => subscribers += new_subscriber;
        //public void Unsubscribe(SendEmails subscriber) => subscribers -= subscriber;
        //public event SendEmails NewIssue
        //{
        //    add { subscribers += value; }
        //    remove { subscribers -= value; }
        //}

        public event SendEmails NewIssue;

        public void MakeEvents()
        {
            NewIssue?.Invoke("Vasya-millionaire", "10 easy ways to get rich");
            NewIssue?.Invoke("Vasya-millionaire", "How I built a successful business");
            NewIssue?.Invoke("Vasya-millionaire", "Legal ways to avoid taxes");
        }
    }
}
