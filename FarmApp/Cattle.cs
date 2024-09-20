using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmApp
{
    public class GiaSuc
    {
        public int SoLuong { get; set; }
        public virtual string TiengKeu() => "";
        public virtual int ChoSua() => 0;
        public virtual int SinhCon() => 0;
    }

    public class Bo : GiaSuc
    {
        public override string TiengKeu() => "Bò: Moo";
        public override int ChoSua() => new Random().Next(0, 21);
        public override int SinhCon() => new Random().Next(1, 4); // 1-3 con
    }

    public class Cuu : GiaSuc
    {
        public override string TiengKeu() => "Cừu: Baa";
        public override int ChoSua() => new Random().Next(0, 6);
        public override int SinhCon() => new Random().Next(1, 3); // 1-2 con
    }

    public class De : GiaSuc
    {
        public override string TiengKeu() => "Dê: Meh";
        public override int ChoSua() => new Random().Next(0, 11);
        public override int SinhCon() => new Random().Next(1, 3); // 1-2 con
    }

}