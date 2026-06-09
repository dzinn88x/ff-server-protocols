using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020017E3 RID: 6115
	[Token(Token = "0x20017E3")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F2F9C", Offset = "0x10F2F9C")]
	internal class UIGachaCouponTipsController : UIEasyListItemController
	{
		// Token: 0x06007648 RID: 30280 RVA: 0x00020CD0 File Offset: 0x0001EED0
		[Token(Token = "0x6007648")]
		[Address(RVA = "0x215FAA0", Offset = "0x215FAA0", VA = "0x7BBC95FAA0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007649 RID: 30281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007649")]
		[Address(RVA = "0x215FAF0", Offset = "0x215FAF0", VA = "0x7BBC95FAF0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600764A RID: 30282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600764A")]
		[Address(RVA = "0x215C2A4", Offset = "0x215C2A4", VA = "0x7BBC95C2A4")]
		public void Refresh()
		{
		}

		// Token: 0x0600764B RID: 30283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600764B")]
		[Address(RVA = "0x215D82C", Offset = "0x215D82C", VA = "0x7BBC95D82C")]
		public void SetViewData(Item itemData, bool clickable = false, bool staticTime = true)
		{
		}

		// Token: 0x0600764C RID: 30284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600764C")]
		[Address(RVA = "0x215FF50", Offset = "0x215FF50", VA = "0x7BBC95FF50", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x0600764D RID: 30285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600764D")]
		[Address(RVA = "0x215FB7C", Offset = "0x215FB7C", VA = "0x7BBC95FB7C")]
		private void SetStaticTime()
		{
		}

		// Token: 0x0600764E RID: 30286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600764E")]
		[Address(RVA = "0x215FD7C", Offset = "0x215FD7C", VA = "0x7BBC95FD7C")]
		private void SetDynamicTime()
		{
		}

		// Token: 0x0600764F RID: 30287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600764F")]
		[Address(RVA = "0x215FFFC", Offset = "0x215FFFC", VA = "0x7BBC95FFFC")]
		public UIGachaCouponTipsController()
		{
		}

		// Token: 0x04008D35 RID: 36149
		[Token(Token = "0x4008D35")]
		[FieldOffset(Offset = "0x70")]
		private UIGachaCouponTipsView m_View;

		// Token: 0x04008D36 RID: 36150
		[Token(Token = "0x4008D36")]
		[FieldOffset(Offset = "0x78")]
		private UIStandardItemMAXBController m_ItemController;

		// Token: 0x04008D37 RID: 36151
		[Token(Token = "0x4008D37")]
		[FieldOffset(Offset = "0x80")]
		private Item m_ItemData;
	}
}
