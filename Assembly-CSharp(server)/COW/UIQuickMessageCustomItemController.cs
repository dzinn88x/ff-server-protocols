using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200166A RID: 5738
	[Token(Token = "0x200166A")]
	public class UIQuickMessageCustomItemController : UIEasyListItemController
	{
		// Token: 0x060067CF RID: 26575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067CF")]
		[Address(RVA = "0x1FF76C0", Offset = "0x1FF76C0", VA = "0x7BBC7F76C0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060067D0 RID: 26576 RVA: 0x0001D838 File Offset: 0x0001BA38
		[Token(Token = "0x60067D0")]
		[Address(RVA = "0x1FF7724", Offset = "0x1FF7724", VA = "0x7BBC7F7724")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060067D1 RID: 26577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067D1")]
		[Address(RVA = "0x1FF7774", Offset = "0x1FF7774", VA = "0x7BBC7F7774", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x060067D2 RID: 26578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067D2")]
		[Address(RVA = "0x1FF7778", Offset = "0x1FF7778", VA = "0x7BBC7F7778")]
		public UIQuickMessageCustomItemController()
		{
		}

		// Token: 0x040084F4 RID: 34036
		[Token(Token = "0x40084F4")]
		[FieldOffset(Offset = "0x70")]
		private UIQuickMessageCustomItemView m_View;
	}
}
