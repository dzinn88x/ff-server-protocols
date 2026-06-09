using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001A38 RID: 6712
	[Token(Token = "0x2001A38")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7C54", Offset = "0x10F7C54")]
	internal class UIMallBannerItemController : UIBaseController
	{
		// Token: 0x06008CF5 RID: 36085 RVA: 0x00025980 File Offset: 0x00023B80
		[Token(Token = "0x6008CF5")]
		[Address(RVA = "0x1CE7F24", Offset = "0x1CE7F24", VA = "0x7BBC4E7F24")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008CF6 RID: 36086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CF6")]
		[Address(RVA = "0x1CE7F74", Offset = "0x1CE7F74", VA = "0x7BBC4E7F74", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008CF7 RID: 36087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CF7")]
		[Address(RVA = "0x1CE7FD8", Offset = "0x1CE7FD8", VA = "0x7BBC4E7FD8")]
		public void UpdateUIData(uint bannerId)
		{
		}

		// Token: 0x06008CF8 RID: 36088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008CF8")]
		[Address(RVA = "0x1CE8194", Offset = "0x1CE8194", VA = "0x7BBC4E8194")]
		public UIMallBannerItemController()
		{
		}

		// Token: 0x0400992E RID: 39214
		[Token(Token = "0x400992E")]
		[FieldOffset(Offset = "0x58")]
		private UIMallBannerItemView m_View;
	}
}
