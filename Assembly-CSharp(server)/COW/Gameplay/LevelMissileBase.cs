using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x0200287A RID: 10362
	[Token(Token = "0x200287A")]
	internal abstract class LevelMissileBase : BaseLevelObject, e]hwa~l
	{
		// Token: 0x0600DB04 RID: 56068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DB04")]
		[Address(RVA = "0x1EC0B58", Offset = "0x1EC0B58", VA = "0x7BBC6C0B58", Slot = "32")]
		protected override string GetObjectTag()
		{
			return null;
		}

		// Token: 0x17000EE4 RID: 3812
		// (get) Token: 0x0600DB05 RID: 56069 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DB06 RID: 56070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000EE4")]
		public lvFHM TWl]PbL
		{
			[Token(Token = "0x600DB05")]
			[Address(RVA = "0x1EBD6C4", Offset = "0x1EBD6C4", VA = "0x7BBC6BD6C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11497D0", Offset = "0x11497D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600DB06")]
			[Address(RVA = "0x1EC0BA0", Offset = "0x1EC0BA0", VA = "0x7BBC6C0BA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11497E0", Offset = "0x11497E0")]
			set
			{
			}
		}

		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x0600DB07 RID: 56071 RVA: 0x0003C9F0 File Offset: 0x0003ABF0
		[Token(Token = "0x17000EE5")]
		public float Dv
		{
			[Token(Token = "0x600DB07")]
			[Address(RVA = "0x1EBCAF8", Offset = "0x1EBCAF8", VA = "0x7BBC6BCAF8")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x0600DB08 RID: 56072 RVA: 0x0003CA08 File Offset: 0x0003AC08
		// (set) Token: 0x0600DB09 RID: 56073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000EE6")]
		public bool Ikeu|jV
		{
			[Token(Token = "0x600DB08")]
			[Address(RVA = "0x1EC0BA8", Offset = "0x1EC0BA8", VA = "0x7BBC6C0BA8", Slot = "35")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11497F0", Offset = "0x11497F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600DB09")]
			[Address(RVA = "0x1EC0BB0", Offset = "0x1EC0BB0", VA = "0x7BBC6C0BB0", Slot = "36")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1149800", Offset = "0x1149800")]
			set
			{
			}
		}

		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x0600DB0A RID: 56074 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DB0B RID: 56075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000EE7")]
		public AttackableEntity vwmKJhN
		{
			[Token(Token = "0x600DB0A")]
			[Address(RVA = "0x1EC0BBC", Offset = "0x1EC0BBC", VA = "0x7BBC6C0BBC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1149810", Offset = "0x1149810")]
			get
			{
				return null;
			}
			[Token(Token = "0x600DB0B")]
			[Address(RVA = "0x1EC0BC4", Offset = "0x1EC0BC4", VA = "0x7BBC6C0BC4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1149820", Offset = "0x1149820")]
			protected set
			{
			}
		}

		// Token: 0x0600DB0C RID: 56076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB0C")]
		[Address(RVA = "0x1EBD8F4", Offset = "0x1EBD8F4", VA = "0x7BBC6BD8F4")]
		protected void L\u0080wEBXq(AttackableEntity \u0081|ladnZ)
		{
		}

		// Token: 0x0600DB0D RID: 56077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB0D")]
		[Address(RVA = "0x1EBAF4C", Offset = "0x1EBAF4C", VA = "0x7BBC6BAF4C", Slot = "37")]
		public virtual void Init(ResourceID |xmJ\u007F~o, lvFHM OSvO{nh)
		{
		}

		// Token: 0x0600DB0E RID: 56078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB0E")]
		[Address(RVA = "0x1EC0BCC", Offset = "0x1EC0BCC", VA = "0x7BBC6C0BCC")]
		protected void nRNZjkF()
		{
		}

		// Token: 0x0600DB0F RID: 56079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB0F")]
		[Address(RVA = "0x1EC0D28", Offset = "0x1EC0D28", VA = "0x7BBC6C0D28")]
		public void Recycle()
		{
		}

		// Token: 0x0600DB10 RID: 56080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB10")]
		[Address(RVA = "0x1EC0EDC", Offset = "0x1EC0EDC", VA = "0x7BBC6C0EDC", Slot = "38")]
		protected virtual void Qm]ualY()
		{
		}

		// Token: 0x0600DB11 RID: 56081 RVA: 0x0003CA20 File Offset: 0x0003AC20
		[Token(Token = "0x600DB11")]
		[Address(RVA = "0x1EC0EE0", Offset = "0x1EC0EE0", VA = "0x7BBC6C0EE0", Slot = "39")]
		protected virtual bool wUpbbDM(Player Foy[QIo, ref uint ihrN]TK, ref AttackableEntity VT`lIxO)
		{
			return default(bool);
		}

		// Token: 0x0600DB12 RID: 56082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB12")]
		[Address(RVA = "0x1EC0EE8", Offset = "0x1EC0EE8", VA = "0x7BBC6C0EE8", Slot = "40")]
		public virtual void Fire(s\u0081s]~YL bqdVnD\u007F)
		{
		}

		// Token: 0x0600DB13 RID: 56083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB13")]
		[Address(RVA = "0x1EC0F58", Offset = "0x1EC0F58", VA = "0x7BBC6C0F58", Slot = "27")]
		public override void SyncAction(params object[] OSvO{nh)
		{
		}

		// Token: 0x0600DB14 RID: 56084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB14")]
		[Address(RVA = "0x1EC1134", Offset = "0x1EC1134", VA = "0x7BBC6C1134", Slot = "41")]
		protected virtual void dAU\u0081u]p(\u0081xuzY\u0081F yfq{tix, uint ~||\u0082utT)
		{
		}

		// Token: 0x0600DB15 RID: 56085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB15")]
		[Address(RVA = "0x1EBBAC0", Offset = "0x1EBBAC0", VA = "0x7BBC6BBAC0")]
		protected void tDCRt(\u0081xuzY\u0081F yfq{tix)
		{
		}

		// Token: 0x0600DB16 RID: 56086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB16")]
		[Address(RVA = "0x1EC11C0", Offset = "0x1EC11C0", VA = "0x7BBC6C11C0", Slot = "42")]
		protected virtual void yLIgaqk(AttackableEntity heAkTSO, AttackableEntity \u007FintF|b)
		{
		}

		// Token: 0x0600DB17 RID: 56087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB17")]
		[Address(RVA = "0x1EBBBE4", Offset = "0x1EBBBE4", VA = "0x7BBC6BBBE4")]
		internal void cp(\u0081xuzY\u0081F yfq{tix, uint ~||\u0082utT, uint tqBPY\u007Ff)
		{
		}

		// Token: 0x0600DB18 RID: 56088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB18")]
		[Address(RVA = "0x1EC11C4", Offset = "0x1EC11C4", VA = "0x7BBC6C11C4", Slot = "14")]
		public override void OnFixedUpdate(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600DB19 RID: 56089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB19")]
		[Address(RVA = "0x1EC1238", Offset = "0x1EC1238", VA = "0x7BBC6C1238", Slot = "43")]
		protected virtual void ^k\u0082veqJ(bool lQlasz{, s\u0081s]~YL bqdVnD\u007F)
		{
		}

		// Token: 0x0600DB1A RID: 56090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB1A")]
		[Address(RVA = "0x1EC1294", Offset = "0x1EC1294", VA = "0x7BBC6C1294", Slot = "44")]
		protected virtual void uihE{t\u0082(bool lQlasz{, float OsUltaA)
		{
		}

		// Token: 0x0600DB1B RID: 56091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB1B")]
		[Address(RVA = "0x1EC1320", Offset = "0x1EC1320", VA = "0x7BBC6C1320", Slot = "45")]
		protected virtual void BYNFh~c(float OsUltaA)
		{
		}

		// Token: 0x0600DB1C RID: 56092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB1C")]
		[Address(RVA = "0x1EC1850", Offset = "0x1EC1850", VA = "0x7BBC6C1850", Slot = "46")]
		protected virtual void \u007F(float OsUltaA)
		{
		}

		// Token: 0x0600DB1D RID: 56093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB1D")]
		[Address(RVA = "0x1EC18A4", Offset = "0x1EC18A4", VA = "0x7BBC6C18A4", Slot = "47")]
		protected virtual void RM]\u007FxfU(float OsUltaA)
		{
		}

		// Token: 0x0600DB1E RID: 56094 RVA: 0x0003CA38 File Offset: 0x0003AC38
		[Token(Token = "0x600DB1E")]
		[Address(RVA = "0x1EC1374", Offset = "0x1EC1374", VA = "0x7BBC6C1374")]
		protected bool OjsPiF](bool rrQzbf^, float OsUltaA = 0f, float aixgwfQ = 0f, float qDgxxeI = 0f, bool kd{v^Zz = false)
		{
			return default(bool);
		}

		// Token: 0x0600DB1F RID: 56095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB1F")]
		[Address(RVA = "0x1EC18A8", Offset = "0x1EC18A8", VA = "0x7BBC6C18A8", Slot = "48")]
		public virtual void Explode(Vector3 cC|iom\u007F)
		{
		}

		// Token: 0x0600DB20 RID: 56096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DB20")]
		[Address(RVA = "0x1EC1B10", Offset = "0x1EC1B10", VA = "0x7BBC6C1B10")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1149830", Offset = "0x1149830")]
		private IEnumerator cLeUS\u0080H(Vector3 cC|iom\u007F)
		{
			return null;
		}

		// Token: 0x0600DB21 RID: 56097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB21")]
		[Address(RVA = "0x1EC1BBC", Offset = "0x1EC1BBC", VA = "0x7BBC6C1BBC", Slot = "49")]
		protected virtual void xdYCtFz(Vector3 cC|iom\u007F)
		{
		}

		// Token: 0x0600DB22 RID: 56098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB22")]
		[Address(RVA = "0x1EC1E08", Offset = "0x1EC1E08", VA = "0x7BBC6C1E08", Slot = "50")]
		protected virtual void ]viwrTt(Vector3 cC|iom\u007F)
		{
		}

		// Token: 0x0600DB23 RID: 56099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB23")]
		[Address(RVA = "0x1EC1F44", Offset = "0x1EC1F44", VA = "0x7BBC6C1F44", Slot = "51")]
		protected virtual void DOcthD\u0082()
		{
		}

		// Token: 0x0600DB24 RID: 56100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DB24")]
		[Address(RVA = "0x1EC1FE0", Offset = "0x1EC1FE0", VA = "0x7BBC6C1FE0")]
		private static string p\u0080[\u0081ABd(Vector3 lyabLZX)
		{
			return null;
		}

		// Token: 0x0600DB25 RID: 56101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB25")]
		[Address(RVA = "0x1EBB6B8", Offset = "0x1EBB6B8", VA = "0x7BBC6BB6B8")]
		protected void yfLPwfs(bool FexeocR)
		{
		}

		// Token: 0x0600DB26 RID: 56102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DB26")]
		[Address(RVA = "0x1EC0998", Offset = "0x1EC0998", VA = "0x7BBC6C0998")]
		protected LevelMissileBase()
		{
		}

		// Token: 0x04010AC5 RID: 68293
		[Token(Token = "0x4010AC5")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1130F14", Offset = "0x1130F14")]
		private lvFHM <\u0080JXX\u0082;

		// Token: 0x04010AC6 RID: 68294
		[Token(Token = "0x4010AC6")]
		[FieldOffset(Offset = "0x70")]
		protected s\u0081s]~YL jshMMlG;

		// Token: 0x04010AC7 RID: 68295
		[Token(Token = "0x4010AC7")]
		[FieldOffset(Offset = "0x78")]
		public {QAb\u0082~u FirePlayerID;

		// Token: 0x04010AC8 RID: 68296
		[Token(Token = "0x4010AC8")]
		[FieldOffset(Offset = "0x90")]
		public bool FiredByLocalPlayer;

		// Token: 0x04010AC9 RID: 68297
		[Token(Token = "0x4010AC9")]
		[FieldOffset(Offset = "0x91")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1130F24", Offset = "0x1130F24")]
		private bool <|xhsYaY>k__BackingField;

		// Token: 0x04010ACA RID: 68298
		[Token(Token = "0x4010ACA")]
		protected const byte q}KgRAS = 128;

		// Token: 0x04010ACB RID: 68299
		[Token(Token = "0x4010ACB")]
		[FieldOffset(Offset = "0x98")]
		protected LevelMissileBase.zSFDrK \u0082iAgQB^;

		// Token: 0x04010ACC RID: 68300
		[Token(Token = "0x4010ACC")]
		[FieldOffset(Offset = "0xA0")]
		protected uint Kpikoyc;

		// Token: 0x04010ACD RID: 68301
		[Token(Token = "0x4010ACD")]
		[FieldOffset(Offset = "0xA4")]
		protected bool Olo~J\u0080p;

		// Token: 0x04010ACE RID: 68302
		[Token(Token = "0x4010ACE")]
		[FieldOffset(Offset = "0xA5")]
		protected bool EWahozd;

		// Token: 0x04010ACF RID: 68303
		[Token(Token = "0x4010ACF")]
		public const int TimeoutFrameCount = 200;

		// Token: 0x04010AD0 RID: 68304
		[Token(Token = "0x4010AD0")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1130F34", Offset = "0x1130F34")]
		private AttackableEntity <zmMvOH\u0081>k__BackingField;

		// Token: 0x04010AD1 RID: 68305
		[Token(Token = "0x4010AD1")]
		[FieldOffset(Offset = "0xB0")]
		protected ResourceID XHQ\u0081yeR;

		// Token: 0x04010AD2 RID: 68306
		[Token(Token = "0x4010AD2")]
		[FieldOffset(Offset = "0xB4")]
		protected bool pzxs\u0080in;

		// Token: 0x0200287B RID: 10363
		[Token(Token = "0x200287B")]
		protected class zSFDrK
		{
			// Token: 0x0600DB27 RID: 56103 RVA: 0x0003CA50 File Offset: 0x0003AC50
			[Token(Token = "0x600DB27")]
			[Address(RVA = "0x1D2BECC", Offset = "0x1D2BECC", VA = "0x7BBC52BECC")]
			public bool ebHJu()
			{
				return default(bool);
			}

			// Token: 0x17000EE8 RID: 3816
			// (get) Token: 0x0600DB28 RID: 56104 RVA: 0x0003CA68 File Offset: 0x0003AC68
			[Token(Token = "0x17000EE8")]
			public float {~^qOa{
			{
				[Token(Token = "0x600DB28")]
				[Address(RVA = "0x1D2BEEC", Offset = "0x1D2BEEC", VA = "0x7BBC52BEEC")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600DB29 RID: 56105 RVA: 0x0003CA80 File Offset: 0x0003AC80
			[Token(Token = "0x600DB29")]
			[Address(RVA = "0x1D2BF28", Offset = "0x1D2BF28", VA = "0x7BBC52BF28")]
			public Vector3 KWXc\u0082c~(float nXxSfxX)
			{
				return default(Vector3);
			}

			// Token: 0x0600DB2A RID: 56106 RVA: 0x0003CA98 File Offset: 0x0003AC98
			[Token(Token = "0x600DB2A")]
			[Address(RVA = "0x1D2BFDC", Offset = "0x1D2BFDC", VA = "0x7BBC52BFDC")]
			public Quaternion HvJGc\u0082w(float nXxSfxX)
			{
				return default(Quaternion);
			}

			// Token: 0x0600DB2B RID: 56107 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DB2B")]
			[Address(RVA = "0x1D2C0B0", Offset = "0x1D2C0B0", VA = "0x7BBC52C0B0")]
			public zSFDrK()
			{
			}

			// Token: 0x04010AD3 RID: 68307
			[Token(Token = "0x4010AD3")]
			[FieldOffset(Offset = "0x10")]
			public int PcqlQCG;

			// Token: 0x04010AD4 RID: 68308
			[Token(Token = "0x4010AD4")]
			[FieldOffset(Offset = "0x14")]
			public float jUsYdAy;

			// Token: 0x04010AD5 RID: 68309
			[Token(Token = "0x4010AD5")]
			[FieldOffset(Offset = "0x18")]
			public uint eFI]LgX;

			// Token: 0x04010AD6 RID: 68310
			[Token(Token = "0x4010AD6")]
			[FieldOffset(Offset = "0x1C")]
			public uint TPMVg\u0082J;

			// Token: 0x04010AD7 RID: 68311
			[Token(Token = "0x4010AD7")]
			[FieldOffset(Offset = "0x20")]
			public Vector3 rTT^h\u007FJ;

			// Token: 0x04010AD8 RID: 68312
			[Token(Token = "0x4010AD8")]
			[FieldOffset(Offset = "0x2C")]
			public Quaternion t~{UBjj;

			// Token: 0x04010AD9 RID: 68313
			[Token(Token = "0x4010AD9")]
			[FieldOffset(Offset = "0x3C")]
			public uint NvyAFxP;

			// Token: 0x04010ADA RID: 68314
			[Token(Token = "0x4010ADA")]
			[FieldOffset(Offset = "0x40")]
			public uint A\u0080k]UI\u0081;

			// Token: 0x04010ADB RID: 68315
			[Token(Token = "0x4010ADB")]
			[FieldOffset(Offset = "0x44")]
			public Vector3 |ZprCW};

			// Token: 0x04010ADC RID: 68316
			[Token(Token = "0x4010ADC")]
			[FieldOffset(Offset = "0x50")]
			public Quaternion VM\u0081a^HA;

			// Token: 0x04010ADD RID: 68317
			[Token(Token = "0x4010ADD")]
			[FieldOffset(Offset = "0x60")]
			public Vector3 L\u0080FEeoZ;
		}

		// Token: 0x0200287C RID: 10364
		[Token(Token = "0x200287C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FEB6C", Offset = "0x10FEB6C")]
		private sealed class kO}rVJU : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600DB2C RID: 56108 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DB2C")]
			[Address(RVA = "0x1D2BD0C", Offset = "0x1D2BD0C", VA = "0x7BBC52BD0C")]
			[DebuggerHidden]
			public kO}rVJU(int zV[Cm[\u0082)
			{
			}

			// Token: 0x0600DB2D RID: 56109 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DB2D")]
			[Address(RVA = "0x1D2BD38", Offset = "0x1D2BD38", VA = "0x7BBC52BD38", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600DB2E RID: 56110 RVA: 0x0003CAB0 File Offset: 0x0003ACB0
			[Token(Token = "0x600DB2E")]
			[Address(RVA = "0x1D2BD3C", Offset = "0x1D2BD3C", VA = "0x7BBC52BD3C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000EE9 RID: 3817
			// (get) Token: 0x0600DB2F RID: 56111 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EE9")]
			private object Current
			{
				[Token(Token = "0x600DB2F")]
				[Address(RVA = "0x1D2BE54", Offset = "0x1D2BE54", VA = "0x7BBC52BE54", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600DB30 RID: 56112 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DB30")]
			[Address(RVA = "0x1D2BE5C", Offset = "0x1D2BE5C", VA = "0x7BBC52BE5C", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000EEA RID: 3818
			// (get) Token: 0x0600DB31 RID: 56113 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EEA")]
			private object Current
			{
				[Token(Token = "0x600DB31")]
				[Address(RVA = "0x1D2BEC4", Offset = "0x1D2BEC4", VA = "0x7BBC52BEC4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04010ADE RID: 68318
			[Token(Token = "0x4010ADE")]
			[FieldOffset(Offset = "0x10")]
			private int zV[Cm[\u0082;

			// Token: 0x04010ADF RID: 68319
			[Token(Token = "0x4010ADF")]
			[FieldOffset(Offset = "0x18")]
			private object YYdxtU];

			// Token: 0x04010AE0 RID: 68320
			[Token(Token = "0x4010AE0")]
			[FieldOffset(Offset = "0x20")]
			public LevelMissileBase poIzdvJ;

			// Token: 0x04010AE1 RID: 68321
			[Token(Token = "0x4010AE1")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 cC|iom\u007F;
		}
	}
}
