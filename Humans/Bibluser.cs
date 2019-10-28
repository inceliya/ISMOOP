using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    class Bibluser: Humans
    {
        protected byte BookAmt;
        protected DateTime TicketDate;
        public Bibluser()
        {
            BookAmt = 0;
            TicketDate = DateTime.Now.Date;
        }
        public Bibluser(Bibluser bibluser) : base(bibluser.Name, bibluser.Gender, bibluser.Birthday)
        {
            BookAmt = bibluser.BookAmt;
            TicketDate = bibluser.TicketDate;
        }
        public Bibluser(string name, string gender, DateTime birthday, byte bookamt, DateTime ticketdate) : base(name, gender, birthday)
        {
            SetBookAmt(bookamt);
            SetTicketDate(ticketdate);
        }
        public Bibluser(Humans human, byte bookamt, DateTime ticketdate) : base(human)
        {
            SetBookAmt(bookamt);
            SetTicketDate(ticketdate);
        }
        public void SetBookAmt(byte bookamt)
        {
            if (bookamt < 0 || bookamt > 50)
                throw new Exception("Ошибка ввода кол-ва книг");
            else BookAmt = bookamt;
        }
        public void SetTicketDate(DateTime ticketdate)
        {
            if (ticketdate < DateTime.Now.Date)
                throw new Exception("Срок действия билета не может быть просроченным");
            else TicketDate = ticketdate;
        }
        public byte GetBookAmt()
        {
            return BookAmt;
        }
        public DateTime GetTicketDate()
        {
            return TicketDate;
        }
    }
}
