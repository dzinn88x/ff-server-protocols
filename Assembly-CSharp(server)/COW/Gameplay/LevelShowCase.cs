using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x020028A2 RID: 10402
	[Token(Token = "0x20028A2")]
	public class LevelShowCase : BaseLevelObject
	{
		// Token: 0x0600DC78 RID: 56440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DC78")]
		[Address(RVA = "0x1D3C774", Offset = "0x1D3C774", VA = "0x7BBC53C774", Slot = "32")]
		protected override string GetObjectTag()
		{
			return null;
		}

		// Token: 0x0600DC79 RID: 56441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC79")]
		[Address(RVA = "0x1D3C7BC", Offset = "0x1D3C7BC", VA = "0x7BBC53C7BC")]
		public void InitShowCase()
		{
		}

		// Token: 0x0600DC7A RID: 56442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC7A")]
		[Address(RVA = "0x1D3CBB4", Offset = "0x1D3CBB4", VA = "0x7BBC53CBB4")]
		public void ShowIntroduction()
		{
		}

		// Token: 0x0600DC7B RID: 56443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC7B")]
		[Address(RVA = "0x1D3CE10", Offset = "0x1D3CE10", VA = "0x7BBC53CE10")]
		public void HideIntroduction()
		{
		}

		// Token: 0x0600DC7C RID: 56444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC7C")]
		[Address(RVA = "0x1D3CF34", Offset = "0x1D3CF34", VA = "0x7BBC53CF34", Slot = "27")]
		public override void SyncAction(params object[] OSvO{nh)
		{
		}

		// Token: 0x0600DC7D RID: 56445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC7D")]
		[Address(RVA = "0x1D3CFD8", Offset = "0x1D3CFD8", VA = "0x7BBC53CFD8")]
		public LevelShowCase()
		{
		}

		// Token: 0x04010BAC RID: 68524
		[Token(Token = "0x4010BAC")]
		[FieldOffset(Offset = "0x68")]
		public Transform m_ItemRoot;

		// Token: 0x04010BAD RID: 68525
		[Token(Token = "0x4010BAD")]
		[FieldOffset(Offset = "0x70")]
		public Transform m_Bottom;

		// Token: 0x04010BAE RID: 68526
		[Token(Token = "0x4010BAE")]
		[FieldOffset(Offset = "0x78")]
		public Transform m_Effect;

		// Token: 0x04010BAF RID: 68527
		[Token(Token = "0x4010BAF")]
		[FieldOffset(Offset = "0x80")]
		public Transform m_EffectLow;

		// Token: 0x04010BB0 RID: 68528
		[Token(Token = "0x4010BB0")]
		[FieldOffset(Offset = "0x88")]
		public uint m_DataID;

		// Token: 0x04010BB1 RID: 68529
		[Token(Token = "0x4010BB1")]
		[FieldOffset(Offset = "0x90")]
		private ArenaShowCaseData d\u0082o{Q}E;
	}
}
