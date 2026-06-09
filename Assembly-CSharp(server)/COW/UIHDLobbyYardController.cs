using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200151B RID: 5403
	[Token(Token = "0x200151B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE154", Offset = "0x10EE154")]
	public class UIHDLobbyYardController : UINavigationController
	{
		// Token: 0x06005CC9 RID: 23753 RVA: 0x0001AFD0 File Offset: 0x000191D0
		[Token(Token = "0x6005CC9")]
		[Address(RVA = "0x16AEA6C", Offset = "0x16AEA6C", VA = "0x7BBBEAEA6C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005CCA RID: 23754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CCA")]
		[Address(RVA = "0x16AEABC", Offset = "0x16AEABC", VA = "0x7BBBEAEABC", Slot = "36")]
		public override List<string> GetNeedShowUI3dObjectNames()
		{
			return null;
		}

		// Token: 0x06005CCB RID: 23755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CCB")]
		[Address(RVA = "0x16AEB24", Offset = "0x16AEB24", VA = "0x7BBBEAEB24", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005CCC RID: 23756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CCC")]
		[Address(RVA = "0x16AEDBC", Offset = "0x16AEDBC", VA = "0x7BBBEAEDBC", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x06005CCD RID: 23757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CCD")]
		[Address(RVA = "0x16AEDC8", Offset = "0x16AEDC8", VA = "0x7BBBEAEDC8", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06005CCE RID: 23758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CCE")]
		[Address(RVA = "0x16AEDD0", Offset = "0x16AEDD0", VA = "0x7BBBEAEDD0", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06005CCF RID: 23759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CCF")]
		[Address(RVA = "0x16AEDD8", Offset = "0x16AEDD8", VA = "0x7BBBEAEDD8")]
		private void OnClickCloseButton()
		{
		}

		// Token: 0x06005CD0 RID: 23760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CD0")]
		[Address(RVA = "0x16AEE74", Offset = "0x16AEE74", VA = "0x7BBBEAEE74")]
		private void OnClickShareButton()
		{
		}

		// Token: 0x06005CD1 RID: 23761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CD1")]
		[Address(RVA = "0x16AF078", Offset = "0x16AF078", VA = "0x7BBBEAF078", Slot = "23")]
		public override void BeforeScreenshot()
		{
		}

		// Token: 0x06005CD2 RID: 23762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CD2")]
		[Address(RVA = "0x16AF0AC", Offset = "0x16AF0AC", VA = "0x7BBBEAF0AC", Slot = "24")]
		public override void AfterScreenshot()
		{
		}

		// Token: 0x06005CD3 RID: 23763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CD3")]
		[Address(RVA = "0x16AF0E0", Offset = "0x16AF0E0", VA = "0x7BBBEAF0E0")]
		public UIHDLobbyYardController()
		{
		}

		// Token: 0x04007EBD RID: 32445
		[Token(Token = "0x4007EBD")]
		[FieldOffset(Offset = "0xB0")]
		private UIHDLobbyYardView m_View;

		// Token: 0x04007EBE RID: 32446
		[Token(Token = "0x4007EBE")]
		[FieldOffset(Offset = "0x0")]
		private static List<string> UI3DOBJECT_NAMES;
	}
}
