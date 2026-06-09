using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BD6 RID: 7126
	[Token(Token = "0x2001BD6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FAF94", Offset = "0x10FAF94")]
	internal class UIWaitingForRequestController : UIBaseController
	{
		// Token: 0x06009A1D RID: 39453 RVA: 0x00028938 File Offset: 0x00026B38
		[Token(Token = "0x6009A1D")]
		[Address(RVA = "0x16854FC", Offset = "0x16854FC", VA = "0x7BBBE854FC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009A1E RID: 39454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A1E")]
		[Address(RVA = "0x168554C", Offset = "0x168554C", VA = "0x7BBBE8554C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009A1F RID: 39455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A1F")]
		[Address(RVA = "0x16855B0", Offset = "0x16855B0", VA = "0x7BBBE855B0")]
		public void SetBlockClick(bool flag)
		{
		}

		// Token: 0x06009A20 RID: 39456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A20")]
		[Address(RVA = "0x16855F8", Offset = "0x16855F8", VA = "0x7BBBE855F8")]
		public UIWaitingForRequestController()
		{
		}

		// Token: 0x0400A118 RID: 41240
		[Token(Token = "0x400A118")]
		[FieldOffset(Offset = "0x58")]
		private UIWaitingForRequestView m_View;
	}
}
