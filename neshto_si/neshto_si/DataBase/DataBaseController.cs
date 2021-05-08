using neshto_si.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace neshto_si.DataBase
{
    public class DataBaseController
    {
        private Madura3 context;

        public DataBaseController() { }
        public DataBaseController(Madura3 context)
        {
            this.context = context;
        }
        /*crud
        create
        read
        update 
        delete*/
        public int createUser(User u)
        {
            context.users.Add(u);
            context.SaveChanges();
            return u.id;
        }
        public int createTicket(Ticket u)
        {
            context.tickets.Add(u);
            context.SaveChanges();
            return u.id;
        }
        public int createLine(Line u)
        {
            context.lines.Add(u);
            context.SaveChanges();
            return u.id;        }
        public int createTrain(Train u)
        {
            context.trains.Add(u);
            context.SaveChanges();
            return u.id;
        }
        public List<User> getAllUsers()
        {
            return context.users.ToList();
        }
        public List<Train> getAllTrains()
        {
            return context.trains.ToList();
        }
        public List<Line> getAllLines()
        {
            return context.lines.ToList();
        }
        public List<Ticket> getAllTickets()
        {
            return context.tickets.ToList();
        }
        public void updateUser(User u)
        {
            User item = context.users.Find(u.id);
            context.Entry(item).CurrentValues.SetValues(u);

            context.SaveChanges();
        }
        public void updateTrain(Train u)
        {
            Train item = context.trains.Find(u.id);
            context.Entry(item).CurrentValues.SetValues(u);

            context.SaveChanges();
        }
        public void updateTicket(Ticket u)
        {
            Ticket item = context.tickets.Find(u.id);
            context.Entry(item).CurrentValues.SetValues(u);

            context.SaveChanges();
        }
        public void updateLine(Line u)
        {
            Line item = context.lines.Find(u.id);
            context.Entry(item).CurrentValues.SetValues(u);

            context.SaveChanges();
        }
        public void deleteUser(int id)
        {
            context.users.Remove(context.users.Find(id));
            context.SaveChanges();
        }
        public void deleteTrain(int id)
        {
            context.trains.Remove(context.trains.Find(id));
            context.SaveChanges();
        }
        public void deleteLine(int id)
        {
            context.lines.Remove(context.lines.Find(id));
            context.SaveChanges();
        }
        public void deleteTicket(int id)
        {
            context.tickets.Remove(context.tickets.Find(id));
            context.SaveChanges();
        }
    }
}
