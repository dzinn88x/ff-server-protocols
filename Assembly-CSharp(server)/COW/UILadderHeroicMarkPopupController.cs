using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200152A RID: 5418
	[Token(Token = "0x200152A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE2A4", Offset = "0x10EE2A4")]
	public class UILadderHeroicMarkPopupController : UIPopupWindowController
	{
		// Token: 0x06005D44 RID: 23876 RVA: 0x0001B168 File Offset: 0x00019368
		[Token(Token = "0x6005D44")]
		[Address(RVA = "0x1E853AC", Offset = "0x1E853AC", VA = "0x7BBC6853AC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005D45 RID: 23877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D45")]
		[Address(RVA = "0x1E853FC", Offset = "0x1E853FC", VA = "0x7BBC6853FC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005D46 RID: 23878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D46")]
		[Address(RVA = "0x1E855A4", Offset = "0x1E855A4", VA = "0x7BBC6855A4", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06005D47 RID: 23879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D47")]
		[Address(RVA = "0x1E856D8", Offset = "0x1E856D8", VA = "0x7BBC6856D8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005D48 RID: 23880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D48")]
		[Address(RVA = "0x1E857A4", Offset = "0x1E857A4", VA = "0x7BBC6857A4")]
		private void OnMaskClick()
		{
		}

		// Token: 0x06005D49 RID: 23881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D49")]
		[Address(RVA = "0x1E857B8", Offset = "0x1E857B8", VA = "0x7BBC6857B8")]
		public void PlayAnim(EHeroicMarkType t, uint valBefore, uint valAfter)
		{
		}

		// Token: 0x06005D4A RID: 23882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D4A")]
		[Address(RVA = "0x1E85CA4", Offset = "0x1E85CA4", VA = "0x7BBC685CA4")]
		private void OnAnimEvtOccur(params object[] data)
		{
		}

		// Token: 0x06005D4B RID: 23883 RVA: 0x0001B180 File Offset: 0x00019380
		[Token(Token = "0x6005D4B")]
		[Address(RVA = "0x1E85E48", Offset = "0x1E85E48", VA = "0x7BBC685E48", Slot = "30")]
		public override int GlassDelay()
		{
			return 0;
		}

		// Token: 0x06005D4C RID: 23884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D4C")]
		[Address(RVA = "0x1E85E50", Offset = "0x1E85E50", VA = "0x7BBC685E50")]
		public UILadderHeroicMarkPopupController()
		{
		}

		// Token: 0x04007EF5 RID: 32501
		[Token(Token = "0x4007EF5")]
		[FieldOffset(Offset = "0x98")]
		private UILadderHeroicMarkPopupView m_View;

		// Token: 0x04007EF6 RID: 32502
		[Token(Token = "0x4007EF6")]
		private const string ANIM_END = "AnimEnd";

		// Token: 0x04007EF7 RID: 32503
		[Token(Token = "0x4007EF7")]
		private const string ANIM_FIRST = "FX_UI_LaddeHeroicMarkPopupFirst";

		// Token: 0x04007EF8 RID: 32504
		[Token(Token = "0x4007EF8")]
		private const string ANIM_LEVELUP = "FX_UI_LaddeHeroicMarkPopupLevelUp";

		// Token: 0x04007EF9 RID: 32505
		[Token(Token = "0x4007EF9")]
		[FieldOffset(Offset = "0xA0")]
		private bool EnableSkip;
	}
}
