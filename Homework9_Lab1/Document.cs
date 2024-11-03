using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9_Lab1
{
    public class Document
    {
        protected string text;

        public Document()
        {

        }

        public Document(string text)
        {
            this.text = text;
        }

        public void SetText(string text)
        {
            this.text = text;
        }

        public override string ToString()
        {
            return text;
        }
    }

    public class Email : Document
    {
        private string sender;
        private string recipient;
        private string title;

        public Email(string sender, string recipient, string title, string text)
        {
            this.sender = sender;
            this.recipient = recipient;
            this.title = title;
            this.text = text;
        }

        public void SetSender(string sender)
        {
            this.sender = sender;
        }

        public void SetRecipient(string recipient)
        {
            this.recipient = recipient;
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public string GetSender()
        {
            return sender;
        }

        public string GetRecipient()
        {
            return recipient;
        }

        public string GetTitle()
        {
            return title;
        }

        public override string ToString()
        {
            return $"From: {sender}\nTo: {recipient}\nTitle: {title}\nBody: {text}";
        }
    }

    public class File : Document
    {
        private string pathname;

        public File(string pathname, string text)
        {
            this.pathname = pathname;
            this.text = text;
        }

        public void SetPathname(string pathname)
        {
            this.pathname = pathname;
        }

        public string GetPathname()
        {
            return pathname;
        }

        public override string ToString()
        {
            return $"Path: {pathname}\nContents: {text}";
        }
    }
}