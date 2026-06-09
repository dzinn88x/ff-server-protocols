using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001647 RID: 5703
	[Token(Token = "0x2001647")]
	public class UIHudReaperMatchResultItemController : UIBaseController
	{
		// Token: 0x060066E7 RID: 26343 RVA: 0x0001D5B0 File Offset: 0x0001B7B0
		[Token(Token = "0x60066E7")]
		[Address(RVA = "0x17EAF08", Offset = "0x17EAF08", VA = "0x7BBBFEAF08")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060066E8 RID: 26344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066E8")]
		[Address(RVA = "0x17EAF58", Offset = "0x17EAF58", VA = "0x7BBBFEAF58", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060066E9 RID: 26345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066E9")]
		[Address(RVA = "0x17EADEC", Offset = "0x17EADEC", VA = "0x7BBBFEADEC")]
		public void SetViewData(TeammateStats data)
		{
		}

		// Token: 0x060066EA RID: 26346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066EA")]
		[Address(RVA = "0x17EB02C", Offset = "0x17EB02C", VA = "0x7BBBFEB02C")]
		private void RefreshView()
		{
		}

		// Token: 0x060066EB RID: 26347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066EB")]
		[Address(RVA = "0x17EADE4", Offset = "0x17EADE4", VA = "0x7BBBFEADE4")]
		public void SetLocalID(ulong localAccountID)
		{
		}

		// Token: 0x060066EC RID: 26348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066EC")]
		[Address(RVA = "0x17EB18C", Offset = "0x17EB18C", VA = "0x7BBBFEB18C")]
		private void SetNameIcon()
		{
		}

		// Token: 0x060066ED RID: 26349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066ED")]
		[Address(RVA = "0x17EB398", Offset = "0x17EB398", VA = "0x7BBBFEB398")]
		private void SetFriendBtnState()
		{
		}

		// Token: 0x060066EE RID: 26350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066EE")]
		[Address(RVA = "0x17EB554", Offset = "0x17EB554", VA = "0x7BBBFEB554")]
		private void SetBGState()
		{
		}

		// Token: 0x060066EF RID: 26351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066EF")]
		[Address(RVA = "0x17EB6AC", Offset = "0x17EB6AC", VA = "0x7BBBFEB6AC")]
		private void OnAddFriend()
		{
		}

		// Token: 0x060066F0 RID: 26352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066F0")]
		[Address(RVA = "0x17EB7FC", Offset = "0x17EB7FC", VA = "0x7BBBFEB7FC")]
		public UIHudReaperMatchResultItemController()
		{
		}

		// Token: 0x04008477 RID: 33911
		[Token(Token = "0x4008477")]
		[FieldOffset(Offset = "0x58")]
		private TeammateStats m_Data;

		// Token: 0x04008478 RID: 33912
		[Token(Token = "0x4008478")]
		[FieldOffset(Offset = "0x60")]
		private UIHudReaperMatchResultItemView m_View;

		// Token: 0x04008479 RID: 33913
		[Token(Token = "0x4008479")]
		[FieldOffset(Offset = "0x68")]
		private int m_Index;

		// Token: 0x0400847A RID: 33914
		[Token(Token = "0x400847A")]
		[FieldOffset(Offset = "0x6C")]
		private bool m_IsLocal;

		// Token: 0x0400847B RID: 33915
		[Token(Token = "0x400847B")]
		[FieldOffset(Offset = "0x70")]
		private ulong m_LocalAccountID;

		// Token: 0x0400847C RID: 33916
		[Token(Token = "0x400847C")]
		private const uint SELFNAMECOLOR = 4157231103U;
	}
}
