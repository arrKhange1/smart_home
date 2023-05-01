using System;

namespace UmniyDom
{
	public partial class Form : System.Windows.Forms.Form
	{
		double atm, kot, kond, reg;
		double a, b, c, d, e, f, ba, bb, bc, bd, be;
		double pa, pb, pc, pd, pe, pf, pba, pbb, pbc, pbd, pbe;
		double da, db, dc, dd, de, df, dba, dbb, dbc, dbd, dbe;
		double katm, kbat, kroom, dt, t;
		bool wina, winb, winc, wind, wine, doora, doorb, doorc, doord, doore, door;

		public Form()
		{
			InitializeComponent();
			StartSet();
		}

		public void StartSet()
		{
			atm = TAtm.Value;
			kot = TKot.Value;
			kond = TKond.Value;
			reg = TReg.Value;
			LKond.Text = ((int)kond).ToString();
			LTKond.Text = "Кондиционер: " + ((int)kond).ToString();
			LKot.Text = "Температура котла: " + ((int)kot).ToString();
			LAtm.Text = "Температура атмосферы: " + ((int)atm).ToString();
			LReg.Text = "Поддерживать: " + ((int)reg).ToString();
			katm = (double)KAtm.Value / 100;
			kbat = (double)KBat.Value / 100;
			kroom = (double)Room.Value / 100;
			LKAtm.Text = "Влияние атмосферы: " + katm.ToString();
			LKBat.Text = "Влияние нагревателей: " + kbat.ToString();
			LKRoom.Text = "Влияние соседних комнат: " + kroom.ToString();
			a = 20; b = 20; c = 20; d = 20; e = 20; f = 20;
			ba = bb = bc = bd = be = kot;
			wina = true; winb = true; winc = true; wind = true; wine = true;
			doora = true; doorb = true; doorc = true; doord = true; doore = true; door = true;
			dt = 0.5;
			Tick();
		}

		void PA()
		{
			pa = kbat * (ba - a);
			if (wina) pa += katm * (atm - a);
			if (doora) pa += kroom * (f - a);
			pba = kbat * (a - ba) + 0.8 * (kot - ba);
			if (wina) pba += katm * (atm - ba);
		}

		void PB()
		{
			pb = kbat * (bb - b);
			if (winb) pb += katm * (atm - b);
			if (doorb) pb += kroom * (f - b);
			pbb = kbat * (b - bb) + 0.8 * (kot - bb);
			if (winb) pbb += katm * (atm - bb);
		}

		void PC()
		{
			pc = kbat * (bc - c);
			if (winc) pc += katm * (atm - c);
			if (doorc) pc += kroom * (d - c);
			pbc = kbat * (c - bc) + 0.8 * (kot - bc);
			if (winc) pbc += katm * (atm - bc);
		}

		void PD()
		{
			pd = kbat * (bd - d);
			if (wind) pd += katm * (atm - d);
			if (doord) pd += kroom * (f - d);
			pbd = kbat * (d - bd) + 0.8 * (kot - bd);
			if (wind) pbd += katm * (atm - bd);
		}

		void PE()
		{
			pe = kbat * (be - e);
			if (wine) pe += katm * (atm - e);
			if (doore) pe += kroom * (f - e);
			pbe = kbat * (e - be) + 0.8 * (kot - be);
			if (wine) pbe += katm * (atm - be);
		}

		void PF()
		{
			pf = 0;
			if (LTKond.Checked) pf =kbat * (kond - f);
			if (doora) pf += kroom * (a - f);
			if (doorb) pf += kroom * (b - f);
			if (doord) pf += kroom * (d - f);
			if (doore) pf += kroom * (e - f);
			if (door) pf += katm * (atm - f);
		}

		void Reg()
		{
			/*if (reg - f > 5 && pf < reg - f)
			{
				if (TKot.Value + 1 <= TKot.Maximum)
				{
					++TKot.Value;
					TKot_Scroll(new object(), new EventArgs());
				}
			}
			else if (f - reg > 5 && pf > reg - f)
			{
				if (TKot.Value - 1 >= TKot.Minimum)
				{
					--TKot.Value;
					TKot_Scroll(new object(), new EventArgs());
				}
			}*/
			double raznica = f - reg;
			double proizvodnaya = df / dt;
			if (proizvodnaya + raznica > 1)
			{
				if (TKot.Value - (int)Math.Abs(proizvodnaya + raznica) >= TKot.Minimum)
				{
					TKot.Value -= (int)Math.Abs(proizvodnaya + raznica);
				}
				else TKot.Value = TKot.Minimum;
				TKot_Scroll(new object(), new EventArgs());

				if (TKot.Value == TKot.Minimum)
				{
					LTKond.Checked = true;
					if (TKond.Value - (int)Math.Abs(proizvodnaya + raznica) >= TKond.Minimum)
						TKond.Value -= (int)Math.Abs(proizvodnaya + raznica);
					else TKond.Value = TKond.Minimum;
					TKond_Scroll(new object(), new EventArgs());
				}
			}
			if (proizvodnaya + raznica < -1)
			{
				if (TKot.Value + (int)Math.Abs(proizvodnaya + raznica) <= TKot.Maximum)
				{
					TKot.Value += (int)Math.Abs(proizvodnaya + raznica);
				}
				else TKot.Value = TKot.Maximum;
				TKot_Scroll(new object(), new EventArgs());

				LTKond.Checked = false;
			}
		}

		void Tick()
		{
			if (RegOn.Checked) Reg();
			PA();
			PB();
			PC();
			PD();
			PE();
			PF();
			da = pa * dt;
			db = pb * dt;
			dc = pc * dt;
			dd = pd * dt;
			de = pe * dt;
			df = pf * dt;
			dba = pba * dt;
			dbb = pbb * dt;
			dbc = pbc * dt;
			dbd = pbd * dt;
			dbe = pbe * dt;
			a += da;
			b += db;
			c += dc;
			d += dd;
			e += de;
			f += df;
			ba += dba;
			bb += dbb;
			bc += dbc;
			bd += dbd;
			be += dbe;
			t += dt;
			t = Math.Round(t, 2);
			ShowValues();
		}

		void ShowValues()
		{
			LA.Text = "A: " + ((int)a).ToString();
			LB.Text = "B: " + ((int)b).ToString();
			LC.Text = "C: " + ((int)c).ToString();
			LD.Text = "D: " + ((int)d).ToString();
			LE.Text = "E: " + ((int)e).ToString();
			LF.Text = "F: " + ((int)f).ToString();
			LBA.Text = ((int)ba).ToString();
			LBB.Text = ((int)bb).ToString();
			LBC.Text = ((int)bc).ToString();
			LBD.Text = ((int)bd).ToString();
			LBE.Text = ((int)be).ToString();
			LT.Text = "Время: " + t.ToString();
		}

		private void RegOn_CheckedChanged(object sender, EventArgs e)
		{
			if (RegOn.Checked)
			{
				TKot.Enabled = false;
				LTKond.Enabled = false;
				LTKond.Checked = false;
				TReg.Enabled = true;
			}
			else
			{
				TKot.Enabled = true;
				LTKond.Enabled = true;
				LTKond.Checked = false;
				TReg.Enabled = false;
			}
		}

		private void LTKond_CheckedChanged(object sender, EventArgs e)
		{
			if (LTKond.Checked) LKond.Text = ((int)kond).ToString();
			if (LTKond.Checked && !RegOn.Checked)
			{
				TKond.Enabled = true;
			}
			else if(!LTKond.Checked)
			{
				TKond.Enabled = false;
				LKond.Text = "Выкл";
			}
		}

		private void Room_Scroll(object sender, EventArgs e)
		{
			kroom = (double)Room.Value / 100;
			LKRoom.Text = "Влияние соседних комнат: " + kroom.ToString();
		}

		private void KBat_Scroll(object sender, EventArgs e)
		{
			kbat = (double)KBat.Value / 100;
			LKBat.Text = "Влияние нагревателей: " + kbat.ToString();
		}

		private void KAtm_Scroll(object sender, EventArgs e)
		{
			katm = (double)KAtm.Value / 100;
			LKAtm.Text = "Влияние атмосферы: " + katm.ToString();
		}

		private void TReg_Scroll(object sender, EventArgs e)
		{
			reg = TReg.Value;
			LReg.Text = "Поддерживать: " + ((int)reg).ToString();
		}

		private void TAtm_Scroll(object sender, EventArgs e)
		{
			atm = TAtm.Value;
			LAtm.Text = "Температура атмосферы: " + ((int)atm).ToString();
		}

		private void TKot_Scroll(object sender, EventArgs e)
		{
			kot = TKot.Value;
			LKot.Text = "Температура котла: " + ((int)kot).ToString();
		}

		private void TKond_Scroll(object sender, EventArgs e)
		{
			kond = TKond.Value;
			LTKond.Text = "Кондиционер: " + ((int)kond).ToString();
			LKond.Text = ((int)kond).ToString();
		}

		private void BTick_Click(object sender, EventArgs e)
		{
			Tick();
		}

		private void WinE_Click(object sender, EventArgs e)
		{
			wine = !wine;
			if (wine) WinE.Text = "О";
			else WinE.Text = "З";
		}

		private void WinC_Click(object sender, EventArgs e)
		{
			winc = !winc;
			if (winc) WinC.Text = "О";
			else WinC.Text = "З";
		}

		private void WinD_Click(object sender, EventArgs e)
		{
			wind = !wind;
			if (wind) WinD.Text = "О";
			else WinD.Text = "З";
		}

		private void WinB_Click(object sender, EventArgs e)
		{
			winb = !winb;
			if (winb) WinB.Text = "Открыто";
			else WinB.Text = "Закрыто";
		}

		private void WinA_Click(object sender, EventArgs e)
		{
			wina = !wina;
			if (wina) WinA.Text = "Открыто";
			else WinA.Text = "Закрыто";
		}

		private void Door_Click(object sender, EventArgs e)
		{
			door = !door;
			if (door) Door.Text = "Открыто";
			else Door.Text = "Закрыто";
		}

		private void DoorE_Click(object sender, EventArgs e)
		{
			doore = !doore;
			if (doore) DoorE.Text = "О";
			else DoorE.Text = "З";
		}

		private void DoorD_Click(object sender, EventArgs e)
		{
			doord = !doord;
			if (doord) DoorD.Text = "Открыто";
			else DoorD.Text = "З";
		}

		private void DoorC_Click(object sender, EventArgs e)
		{
			doorc = !doorc;
			if (doorc) DoorC.Text = "Открыто";
			else DoorC.Text = "З";
		}

		private void DoorA_Click(object sender, EventArgs e)
		{
			doora = !doora;
			if (doora) DoorA.Text = "Открыто";
			else DoorA.Text = "Закрыто";
		}

		private void DoorB_Click(object sender, EventArgs e)
		{
			doorb = !doorb;
			if (doorb) DoorB.Text = "Открыто";
			else DoorB.Text = "Закрыто";
		}

	}
}