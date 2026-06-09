using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x02002850 RID: 10320
	[Token(Token = "0x2002850")]
	public class LevelEmote : BaseLevelObject
	{
		// Token: 0x0600D9A8 RID: 55720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D9A8")]
		[Address(RVA = "0x1EAA6AC", Offset = "0x1EAA6AC", VA = "0x7BBC6AA6AC", Slot = "32")]
		protected override string GetObjectTag()
		{
			return null;
		}

		// Token: 0x0600D9A9 RID: 55721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9A9")]
		[Address(RVA = "0x1EAA6F4", Offset = "0x1EAA6F4", VA = "0x7BBC6AA6F4", Slot = "12")]
		protected override void OnStart()
		{
		}

		// Token: 0x0600D9AA RID: 55722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9AA")]
		[Address(RVA = "0x1EAA6FC", Offset = "0x1EAA6FC", VA = "0x7BBC6AA6FC", Slot = "20")]
		protected override void OnUserDefineReplicationInfo()
		{
		}

		// Token: 0x0600D9AB RID: 55723 RVA: 0x0003C2E8 File Offset: 0x0003A4E8
		[Token(Token = "0x600D9AB")]
		[Address(RVA = "0x1EAA7D8", Offset = "0x1EAA7D8", VA = "0x7BBC6AA7D8", Slot = "22")]
		protected override int GetMaxRepDataCount()
		{
			return 0;
		}

		// Token: 0x0600D9AC RID: 55724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9AC")]
		[Address(RVA = "0x1EAA7E0", Offset = "0x1EAA7E0", VA = "0x7BBC6AA7E0")]
		private void dVN\u0082PKu(bool l]jgxbG, bool TzzPYjI)
		{
		}

		// Token: 0x0600D9AD RID: 55725 RVA: 0x0003C300 File Offset: 0x0003A500
		[Token(Token = "0x600D9AD")]
		[Address(RVA = "0x1EAA860", Offset = "0x1EAA860", VA = "0x7BBC6AA860")]
		public bool IsUsed()
		{
			return default(bool);
		}

		// Token: 0x0600D9AE RID: 55726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9AE")]
		[Address(RVA = "0x1EAA8C4", Offset = "0x1EAA8C4", VA = "0x7BBC6AA8C4")]
		public void InitLevelEmote(uint ^mytTwB)
		{
		}

		// Token: 0x0600D9AF RID: 55727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9AF")]
		[Address(RVA = "0x1EAAB14", Offset = "0x1EAAB14", VA = "0x7BBC6AAB14")]
		public LevelEmote()
		{
		}

		// Token: 0x040109AC RID: 68012
		[Token(Token = "0x40109AC")]
		[FieldOffset(Offset = "0x68")]
		public MeshRenderer m_EmoteModelRender;

		// Token: 0x040109AD RID: 68013
		[Token(Token = "0x40109AD")]
		[FieldOffset(Offset = "0x70")]
		public uint m_EmoteID;
	}
}
