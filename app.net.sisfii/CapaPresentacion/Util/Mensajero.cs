using CapaPresentacion.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Util
{
    public class Mensajero
    {
        public readonly IMailService _mailService;
        public Mensajero(IMailService mailService)
        {
            _mailService = mailService;
        }

        public void Create()
        {
            _mailService.Send();
        }
    }
}
