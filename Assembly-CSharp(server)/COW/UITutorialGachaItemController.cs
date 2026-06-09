using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001BC0 RID: 7104
	[Token(Token = "0x2001BC0")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FAC4C", Offset = "0x10FAC4C")]
	public class UITutorialGachaItemController : UIBaseController
	{
		// Token: 0x06009991 RID: 39313 RVA: 0x000286C8 File Offset: 0x000268C8
		[Token(Token = "0x6009991")]
		[Address(RVA = "0x19F7CF0", Offset = "0x19F7CF0", VA = "0x7BBC1F7CF0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009992 RID: 39314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009992")]
		[Address(RVA = "0x19F7D40", Offset = "0x19F7D40", VA = "0x7BBC1F7D40", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009993 RID: 39315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009993")]
		[Address(RVA = "0x19F7F08", Offset = "0x19F7F08", VA = "0x7BBC1F7F08")]
		public void SetData(AdvertDesc desc)
		{
		}

		// Token: 0x06009994 RID: 39316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009994")]
		[Address(RVA = "0x19F7FCC", Offset = "0x19F7FCC", VA = "0x7BBC1F7FCC")]
		private void OnBtnClose()
		{
		}

		// Token: 0x06009995 RID: 39317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009995")]
		[Address(RVA = "0x19F81BC", Offset = "0x19F81BC", VA = "0x7BBC1F81BC")]
		public UITutorialGachaItemController()
		{
		}

		// Token: 0x0400A0CA RID: 41162
		[Token(Token = "0x400A0CA")]
		[FieldOffset(Offset = "0x58")]
		private UITutorialGachaItemView m_View;
	}
}
