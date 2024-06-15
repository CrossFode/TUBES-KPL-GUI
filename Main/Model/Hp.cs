using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Model
{
    internal class Hp
    {
        public string MerekHp { get; set; }

        public int KodeHp { get; set; }

        public int JumlahHp { get; set; }

        public int HargaHp { get; set; }

        public Hp(string MerekHp, int KodeHp, int JumlahHp, int HargaHp)
        {
            this.MerekHp = MerekHp;
            this.KodeHp = KodeHp;
            this.JumlahHp = JumlahHp;
            this.HargaHp = HargaHp;
        }

        internal static void Add(Hp hp)
        {
            throw new NotImplementedException();
        }

        internal static void RemoveAt(int id)
        {
            throw new NotImplementedException();
        }
    }
}
