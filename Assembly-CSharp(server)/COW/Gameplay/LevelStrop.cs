using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x020028A9 RID: 10409
	[Token(Token = "0x20028A9")]
	public class LevelStrop : BaseLevelObject
	{
		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x0600DCA3 RID: 56483 RVA: 0x0003D128 File Offset: 0x0003B328
		[Token(Token = "0x17000F04")]
		public Vector3 dy{C^hN
		{
			[Token(Token = "0x600DCA3")]
			[Address(RVA = "0x1D3E9C0", Offset = "0x1D3E9C0", VA = "0x7BBC53E9C0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x0600DCA4 RID: 56484 RVA: 0x0003D140 File Offset: 0x0003B340
		[Token(Token = "0x17000F05")]
		public Vector3 dJXh\u0081^T
		{
			[Token(Token = "0x600DCA4")]
			[Address(RVA = "0x1D3E9F0", Offset = "0x1D3E9F0", VA = "0x7BBC53E9F0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600DCA5 RID: 56485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DCA5")]
		[Address(RVA = "0x1D3EA20", Offset = "0x1D3EA20", VA = "0x7BBC53EA20", Slot = "32")]
		protected override string GetObjectTag()
		{
			return null;
		}

		// Token: 0x0600DCA6 RID: 56486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCA6")]
		[Address(RVA = "0x1D3EA68", Offset = "0x1D3EA68", VA = "0x7BBC53EA68", Slot = "12")]
		protected override void OnStart()
		{
		}

		// Token: 0x0600DCA7 RID: 56487 RVA: 0x0003D158 File Offset: 0x0003B358
		[Token(Token = "0x600DCA7")]
		[Address(RVA = "0x1D3ECDC", Offset = "0x1D3ECDC", VA = "0x7BBC53ECDC")]
		public Vector3 GetMoveDir()
		{
			return default(Vector3);
		}

		// Token: 0x0600DCA8 RID: 56488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DCA8")]
		[Address(RVA = "0x1D3EDF0", Offset = "0x1D3EDF0", VA = "0x7BBC53EDF0")]
		public LevelStropShelf GetStartShelf()
		{
			return null;
		}

		// Token: 0x0600DCA9 RID: 56489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DCA9")]
		[Address(RVA = "0x1D3EF7C", Offset = "0x1D3EF7C", VA = "0x7BBC53EF7C")]
		public LevelStropShelf GetEndShelf()
		{
			return null;
		}

		// Token: 0x0600DCAA RID: 56490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCAA")]
		[Address(RVA = "0x1D3F108", Offset = "0x1D3F108", VA = "0x7BBC53F108")]
		public void SetLineVisible(bool lyabLZX)
		{
		}

		// Token: 0x0600DCAB RID: 56491 RVA: 0x0003D170 File Offset: 0x0003B370
		[Token(Token = "0x600DCAB")]
		[Address(RVA = "0x1D3F1DC", Offset = "0x1D3F1DC", VA = "0x7BBC53F1DC")]
		public float GetLength()
		{
			return 0f;
		}

		// Token: 0x0600DCAC RID: 56492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCAC")]
		[Address(RVA = "0x1D3F2F8", Offset = "0x1D3F2F8", VA = "0x7BBC53F2F8", Slot = "26")]
		public override void DoAction(params object[] OSvO{nh)
		{
		}

		// Token: 0x0600DCAD RID: 56493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCAD")]
		[Address(RVA = "0x1D3F6A8", Offset = "0x1D3F6A8", VA = "0x7BBC53F6A8", Slot = "27")]
		public override void SyncAction(params object[] OSvO{nh)
		{
		}

		// Token: 0x0600DCAE RID: 56494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCAE")]
		[Address(RVA = "0x1D3FBF4", Offset = "0x1D3FBF4", VA = "0x7BBC53FBF4")]
		public LevelStrop()
		{
		}

		// Token: 0x04010BC9 RID: 68553
		[Token(Token = "0x4010BC9")]
		[FieldOffset(Offset = "0x68")]
		public Transform StartPoint;

		// Token: 0x04010BCA RID: 68554
		[Token(Token = "0x4010BCA")]
		[FieldOffset(Offset = "0x70")]
		public Transform EndPoint;

		// Token: 0x04010BCB RID: 68555
		[Token(Token = "0x4010BCB")]
		[FieldOffset(Offset = "0x78")]
		public LineRenderer StropLine;

		// Token: 0x04010BCC RID: 68556
		[Token(Token = "0x4010BCC")]
		[FieldOffset(Offset = "0x80")]
		private Collider QLCD\u0082tZ;

		// Token: 0x04010BCD RID: 68557
		[Token(Token = "0x4010BCD")]
		[FieldOffset(Offset = "0x88")]
		private LevelStropShelf BJe\u0081h|R;

		// Token: 0x04010BCE RID: 68558
		[Token(Token = "0x4010BCE")]
		[FieldOffset(Offset = "0x90")]
		private LevelStropShelf iCh~JFu;

		// Token: 0x04010BCF RID: 68559
		[Token(Token = "0x4010BCF")]
		[FieldOffset(Offset = "0x98")]
		private float GwmYLlc;

		// Token: 0x020028AA RID: 10410
		[Token(Token = "0x20028AA")]
		public enum YsiQmNJ
		{
			// Token: 0x04010BD1 RID: 68561
			[Token(Token = "0x4010BD1")]
			GET_ON,
			// Token: 0x04010BD2 RID: 68562
			[Token(Token = "0x4010BD2")]
			GET_OFF
		}
	}
}
