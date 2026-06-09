using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001AB9 RID: 6841
	[Token(Token = "0x2001AB9")]
	public class UIPaymentBundleNewUserItemController : UIPaymentBundleItemController, IUIModelDataChangeObserver
	{
		// Token: 0x06009062 RID: 36962 RVA: 0x00026790 File Offset: 0x00024990
		[Token(Token = "0x6009062")]
		[Address(RVA = "0x16F7A24", Offset = "0x16F7A24", VA = "0x7BBBEF7A24")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009063 RID: 36963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009063")]
		[Address(RVA = "0x16F7A74", Offset = "0x16F7A74", VA = "0x7BBBEF7A74", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009064 RID: 36964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009064")]
		[Address(RVA = "0x16F7C40", Offset = "0x16F7C40", VA = "0x7BBBEF7C40", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009065 RID: 36965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009065")]
		[Address(RVA = "0x16F7D74", Offset = "0x16F7D74", VA = "0x7BBBEF7D74", Slot = "36")]
		protected override void UpdateContents()
		{
		}

		// Token: 0x06009066 RID: 36966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009066")]
		[Address(RVA = "0x16FA024", Offset = "0x16FA024", VA = "0x7BBBEFA024")]
		private void OnPurchaseButtonClick()
		{
		}

		// Token: 0x06009067 RID: 36967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009067")]
		[Address(RVA = "0x16FA7FC", Offset = "0x16FA7FC", VA = "0x7BBBEFA7FC")]
		private void OnPaidFailed(params object[] data)
		{
		}

		// Token: 0x06009068 RID: 36968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009068")]
		[Address(RVA = "0x16FA8D0", Offset = "0x16FA8D0", VA = "0x7BBBEFA8D0")]
		public UIPaymentBundleNewUserItemController()
		{
		}

		// Token: 0x06009069 RID: 36969 RVA: 0x000267A8 File Offset: 0x000249A8
		[Token(Token = "0x6009069")]
		[Address(RVA = "0x16FA93C", Offset = "0x16FA93C", VA = "0x7BBBEFA93C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144878", Offset = "0x1144878")]
		private bool <OnPurchaseButtonClick>b__6_1(SpecialStoreDesc x)
		{
			return default(bool);
		}

		// Token: 0x04009C13 RID: 39955
		[Token(Token = "0x4009C13")]
		[FieldOffset(Offset = "0x98")]
		private UIPaymentBundleNewUserItemView m_View;

		// Token: 0x04009C14 RID: 39956
		[Token(Token = "0x4009C14")]
		[FieldOffset(Offset = "0xA0")]
		private List<UIStandardItemMiniController> m_ContentItems;

		// Token: 0x02001ABA RID: 6842
		[Token(Token = "0x2001ABA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F89D4", Offset = "0x10F89D4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600906B RID: 36971 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600906B")]
			[Address(RVA = "0x16FA9EC", Offset = "0x16FA9EC", VA = "0x7BBBEFA9EC")]
			public <>c()
			{
			}

			// Token: 0x0600906C RID: 36972 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600906C")]
			[Address(RVA = "0x16FA9F4", Offset = "0x16FA9F4", VA = "0x7BBBEFA9F4")]
			internal void <OnPurchaseButtonClick>b__6_0()
			{
			}

			// Token: 0x04009C15 RID: 39957
			[Token(Token = "0x4009C15")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIPaymentBundleNewUserItemController.<>c <>9;

			// Token: 0x04009C16 RID: 39958
			[Token(Token = "0x4009C16")]
			[FieldOffset(Offset = "0x8")]
			public static Action <>9__6_0;
		}
	}
}
