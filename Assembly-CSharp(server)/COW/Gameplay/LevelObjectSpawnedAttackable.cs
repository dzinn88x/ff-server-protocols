using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x02002887 RID: 10375
	[Token(Token = "0x2002887")]
	internal abstract class LevelObjectSpawnedAttackable : LevelObjectSpawned, \u0081{oGdwC
	{
		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x0600DBBF RID: 56255
		[Token(Token = "0x17000EF3")]
		public abstract int |eLiCTf { [Token(Token = "0x600DBBF")] get; }

		// Token: 0x0600DBC0 RID: 56256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBC0")]
		[Address(RVA = "0x1D30594", Offset = "0x1D30594", VA = "0x7BBC530594", Slot = "12")]
		protected override void OnStart()
		{
		}

		// Token: 0x0600DBC1 RID: 56257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBC1")]
		[Address(RVA = "0x1D30650", Offset = "0x1D30650", VA = "0x7BBC530650", Slot = "35")]
		protected override void ]c]~NsN()
		{
		}

		// Token: 0x0600DBC2 RID: 56258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBC2")]
		[Address(RVA = "0x1D3068C", Offset = "0x1D3068C", VA = "0x7BBC53068C", Slot = "13")]
		protected override void OnOnDestroy()
		{
		}

		// Token: 0x0600DBC3 RID: 56259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBC3")]
		[Address(RVA = "0x1D306B4", Offset = "0x1D306B4", VA = "0x7BBC5306B4")]
		protected void KMm()
		{
		}

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x0600DBC4 RID: 56260 RVA: 0x0003CBE8 File Offset: 0x0003ADE8
		// (set) Token: 0x0600DBC5 RID: 56261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000EF4")]
		public bool \u0080xliDYS
		{
			[Token(Token = "0x600DBC4")]
			[Address(RVA = "0x1D30774", Offset = "0x1D30774", VA = "0x7BBC530774", Slot = "46")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11498E4", Offset = "0x11498E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600DBC5")]
			[Address(RVA = "0x1D30680", Offset = "0x1D30680", VA = "0x7BBC530680")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11498F4", Offset = "0x11498F4")]
			private set
			{
			}
		}

		// Token: 0x0600DBC6 RID: 56262 RVA: 0x0003CC00 File Offset: 0x0003AE00
		[Token(Token = "0x600DBC6")]
		[Address(RVA = "0x1D3077C", Offset = "0x1D3077C", VA = "0x7BBC53077C", Slot = "59")]
		public virtual uint GetAttackableID()
		{
			return 0U;
		}

		// Token: 0x0600DBC7 RID: 56263 RVA: 0x0003CC18 File Offset: 0x0003AE18
		[Token(Token = "0x600DBC7")]
		[Address(RVA = "0x1D30784", Offset = "0x1D30784", VA = "0x7BBC530784", Slot = "60")]
		public virtual JDhUTU^ GetAttackableType()
		{
			return JDhUTU^.EAttackableType_None;
		}

		// Token: 0x0600DBC8 RID: 56264 RVA: 0x0003CC30 File Offset: 0x0003AE30
		[Token(Token = "0x600DBC8")]
		[Address(RVA = "0x1D3078C", Offset = "0x1D3078C", VA = "0x7BBC53078C", Slot = "61")]
		public virtual float GetAttackableRadius()
		{
			return 0f;
		}

		// Token: 0x0600DBC9 RID: 56265 RVA: 0x0003CC48 File Offset: 0x0003AE48
		[Token(Token = "0x600DBC9")]
		[Address(RVA = "0x1D30794", Offset = "0x1D30794", VA = "0x7BBC530794", Slot = "62")]
		public virtual Vector3 GetAttackableCenterWS()
		{
			return default(Vector3);
		}

		// Token: 0x0600DBCA RID: 56266 RVA: 0x0003CC60 File Offset: 0x0003AE60
		[Token(Token = "0x600DBCA")]
		[Address(RVA = "0x1D307C8", Offset = "0x1D307C8", VA = "0x7BBC5307C8", Slot = "63")]
		public virtual Vector3 GetHitDamagePos()
		{
			return default(Vector3);
		}

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x0600DBCB RID: 56267 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DBCC RID: 56268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000EF5")]
		public Collider sM\u007FxNNp
		{
			[Token(Token = "0x600DBCB")]
			[Address(RVA = "0x1D307FC", Offset = "0x1D307FC", VA = "0x7BBC5307FC", Slot = "52")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1149904", Offset = "0x1149904")]
			get
			{
				return null;
			}
			[Token(Token = "0x600DBCC")]
			[Address(RVA = "0x1D30804", Offset = "0x1D30804", VA = "0x7BBC530804", Slot = "53")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1149914", Offset = "0x1149914")]
			set
			{
			}
		}

		// Token: 0x0600DBCD RID: 56269 RVA: 0x0003CC78 File Offset: 0x0003AE78
		[Token(Token = "0x600DBCD")]
		[Address(RVA = "0x1D3080C", Offset = "0x1D3080C", VA = "0x7BBC53080C", Slot = "64")]
		public virtual bool NeedAssit()
		{
			return default(bool);
		}

		// Token: 0x0600DBCE RID: 56270 RVA: 0x0003CC90 File Offset: 0x0003AE90
		[Token(Token = "0x600DBCE")]
		[Address(RVA = "0x1D30814", Offset = "0x1D30814", VA = "0x7BBC530814", Slot = "65")]
		public virtual bool IsSameTeamWithPlayerID({QAb\u0082~u hVZ^Lay)
		{
			return default(bool);
		}

		// Token: 0x0600DBCF RID: 56271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DBCF")]
		[Address(RVA = "0x1D30900", Offset = "0x1D30900", VA = "0x7BBC530900")]
		protected uTpWlPV ePByRW{()
		{
			return null;
		}

		// Token: 0x0600DBD0 RID: 56272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBD0")]
		[Address(RVA = "0x1D309D0", Offset = "0x1D309D0", VA = "0x7BBC5309D0", Slot = "66")]
		public virtual void TakeDamageByVehicle(int |moXXXV, {QAb\u0082~u KE`SW[H, TNugLVg |~^O\u0080Iy, int dwdYABP)
		{
		}

		// Token: 0x0600DBD1 RID: 56273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBD1")]
		[Address(RVA = "0x1D30AE0", Offset = "0x1D30AE0", VA = "0x7BBC530AE0", Slot = "67")]
		public virtual void TakeDamage(woZmHkA JkgWmeJ, [Optional] ohSG[ek \u0081{zLQ\u007FM, [Optional] List<float> `KEFVvE, uint iYO}d|F = 0U)
		{
		}

		// Token: 0x0600DBD2 RID: 56274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBD2")]
		[Address(RVA = "0x1D30C3C", Offset = "0x1D30C3C", VA = "0x7BBC530C3C", Slot = "68")]
		public new virtual void TakeHealing(int wE~rpy\u0082, {QAb\u0082~u a\u0082uxIoj, int OhggZRq, [Optional] Vector3 `oVk\u0080^H, [Optional] Vector3 ft|sF}F, [Optional] List<float> `KEFVvE)
		{
		}

		// Token: 0x0600DBD3 RID: 56275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBD3")]
		[Address(RVA = "0x1D30C40", Offset = "0x1D30C40", VA = "0x7BBC530C40")]
		protected LevelObjectSpawnedAttackable()
		{
		}

		// Token: 0x0600DBD4 RID: 56276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DBD4")]
		[Address(RVA = "0x1D30C44", Offset = "0x1D30C44", VA = "0x7BBC530C44", Slot = "41")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x04010B1A RID: 68378
		[Token(Token = "0x4010B1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1130F44", Offset = "0x1130F44")]
		private bool <rDFTJlY>k__BackingField;

		// Token: 0x04010B1B RID: 68379
		[Token(Token = "0x4010B1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1130F54", Offset = "0x1130F54")]
		private Collider <Y{Lwhxh>k__BackingField;
	}
}
