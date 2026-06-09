using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020017D6 RID: 6102
	[Token(Token = "0x20017D6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F2DFC", Offset = "0x10F2DFC")]
	public class UIFriendReunionTitleController : UIBaseController
	{
		// Token: 0x06007594 RID: 30100 RVA: 0x00020A30 File Offset: 0x0001EC30
		[Token(Token = "0x6007594")]
		[Address(RVA = "0x159FC48", Offset = "0x159FC48", VA = "0x7BBBD9FC48")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007595 RID: 30101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007595")]
		[Address(RVA = "0x159FC98", Offset = "0x159FC98", VA = "0x7BBBD9FC98", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007596 RID: 30102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007596")]
		[Address(RVA = "0x159FEA4", Offset = "0x159FEA4", VA = "0x7BBBD9FEA4")]
		private void ShowDetail()
		{
		}

		// Token: 0x06007597 RID: 30103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007597")]
		[Address(RVA = "0x15A0070", Offset = "0x15A0070", VA = "0x7BBBDA0070")]
		public void SetWidth(int width)
		{
		}

		// Token: 0x06007598 RID: 30104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007598")]
		[Address(RVA = "0x15A00F4", Offset = "0x15A00F4", VA = "0x7BBBDA00F4")]
		public void SetData(string name, string desc, bool selfLink = false)
		{
		}

		// Token: 0x06007599 RID: 30105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007599")]
		[Address(RVA = "0x15A0290", Offset = "0x15A0290", VA = "0x7BBBDA0290")]
		public void SetCallbackButton(bool flag)
		{
		}

		// Token: 0x0600759A RID: 30106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600759A")]
		[Address(RVA = "0x15A02F0", Offset = "0x15A02F0", VA = "0x7BBBDA02F0")]
		public void OnClickCallbackButton()
		{
		}

		// Token: 0x0600759B RID: 30107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600759B")]
		[Address(RVA = "0x15A038C", Offset = "0x15A038C", VA = "0x7BBBDA038C")]
		public void OnClickGoto()
		{
		}

		// Token: 0x0600759C RID: 30108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600759C")]
		[Address(RVA = "0x15A0478", Offset = "0x15A0478", VA = "0x7BBBDA0478")]
		public UIFriendReunionTitleController()
		{
		}

		// Token: 0x04008CF5 RID: 36085
		[Token(Token = "0x4008CF5")]
		[FieldOffset(Offset = "0x58")]
		private UIFriendReunionTitleView m_View;

		// Token: 0x04008CF6 RID: 36086
		[Token(Token = "0x4008CF6")]
		[FieldOffset(Offset = "0x60")]
		private string m_Detail;
	}
}
