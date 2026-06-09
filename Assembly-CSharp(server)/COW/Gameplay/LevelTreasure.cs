using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x020028BD RID: 10429
	[Token(Token = "0x20028BD")]
	public class LevelTreasure : BaseLevelObject
	{
		// Token: 0x0600DCF7 RID: 56567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DCF7")]
		[Address(RVA = "0x1D44134", Offset = "0x1D44134", VA = "0x7BBC544134", Slot = "32")]
		protected override string GetObjectTag()
		{
			return null;
		}

		// Token: 0x0600DCF8 RID: 56568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCF8")]
		[Address(RVA = "0x1D4417C", Offset = "0x1D4417C", VA = "0x7BBC54417C", Slot = "27")]
		public override void SyncAction(params object[] OSvO{nh)
		{
		}

		// Token: 0x0600DCF9 RID: 56569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCF9")]
		[Address(RVA = "0x1D44A28", Offset = "0x1D44A28", VA = "0x7BBC544A28")]
		public void OnTreasureTrigger(bool ]sMp{Mx)
		{
		}

		// Token: 0x0600DCFA RID: 56570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCFA")]
		[Address(RVA = "0x1D44C9C", Offset = "0x1D44C9C", VA = "0x7BBC544C9C")]
		public LevelTreasure()
		{
		}

		// Token: 0x04010CF7 RID: 68855
		[Token(Token = "0x4010CF7")]
		[FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public PickupTreasureBox m_PickupTreasureBox;

		// Token: 0x04010CF8 RID: 68856
		[Token(Token = "0x4010CF8")]
		[FieldOffset(Offset = "0x70")]
		public ulong m_OwnerID;

		// Token: 0x04010CF9 RID: 68857
		[Token(Token = "0x4010CF9")]
		[FieldOffset(Offset = "0x78")]
		public bool m_IsDiggedOut;

		// Token: 0x04010CFA RID: 68858
		[Token(Token = "0x4010CFA")]
		[FieldOffset(Offset = "0x7C")]
		public uint m_ContainerID;
	}
}
