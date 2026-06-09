using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200188A RID: 6282
	[Token(Token = "0x200188A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F44FC", Offset = "0x10F44FC")]
	internal class UIHudBuildingSwitchInfoController : UIBaseController
	{
		// Token: 0x06007C5A RID: 31834 RVA: 0x00022308 File Offset: 0x00020508
		[Token(Token = "0x6007C5A")]
		[Address(RVA = "0x19B5438", Offset = "0x19B5438", VA = "0x7BBC1B5438")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007C5B RID: 31835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C5B")]
		[Address(RVA = "0x19B5488", Offset = "0x19B5488", VA = "0x7BBC1B5488", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007C5C RID: 31836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C5C")]
		[Address(RVA = "0x19B55E8", Offset = "0x19B55E8", VA = "0x7BBC1B55E8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007C5D RID: 31837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C5D")]
		[Address(RVA = "0x19B56B4", Offset = "0x19B56B4", VA = "0x7BBC1B56B4")]
		public void SetSprite(string name)
		{
		}

		// Token: 0x06007C5E RID: 31838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C5E")]
		[Address(RVA = "0x19B56FC", Offset = "0x19B56FC", VA = "0x7BBC1B56FC")]
		private void OnSwitchBuildingClick()
		{
		}

		// Token: 0x06007C5F RID: 31839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C5F")]
		[Address(RVA = "0x19B58F4", Offset = "0x19B58F4", VA = "0x7BBC1B58F4")]
		public void SetHighlight(bool val)
		{
		}

		// Token: 0x06007C60 RID: 31840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C60")]
		[Address(RVA = "0x19B598C", Offset = "0x19B598C", VA = "0x7BBC1B598C")]
		private void OnIndexChange(params object[] param)
		{
		}

		// Token: 0x06007C61 RID: 31841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C61")]
		[Address(RVA = "0x19B5A24", Offset = "0x19B5A24", VA = "0x7BBC1B5A24")]
		public UIHudBuildingSwitchInfoController()
		{
		}

		// Token: 0x0400905C RID: 36956
		[Token(Token = "0x400905C")]
		[FieldOffset(Offset = "0x58")]
		public UIHudBuildingSwitchInfoView m_View;

		// Token: 0x0400905D RID: 36957
		[Token(Token = "0x400905D")]
		[FieldOffset(Offset = "0x60")]
		public int Index;
	}
}
