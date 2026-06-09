using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200195B RID: 6491
	[Token(Token = "0x200195B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F61BC", Offset = "0x10F61BC")]
	internal class UIHudSkillStrengthenArmorController : UIBaseController
	{
		// Token: 0x060083CE RID: 33742 RVA: 0x00023CD0 File Offset: 0x00021ED0
		[Token(Token = "0x60083CE")]
		[Address(RVA = "0x16698A4", Offset = "0x16698A4", VA = "0x7BBBE698A4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060083CF RID: 33743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083CF")]
		[Address(RVA = "0x16698F4", Offset = "0x16698F4", VA = "0x7BBBE698F4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060083D0 RID: 33744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083D0")]
		[Address(RVA = "0x1669968", Offset = "0x1669968", VA = "0x7BBBE69968", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060083D1 RID: 33745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083D1")]
		[Address(RVA = "0x1669970", Offset = "0x1669970", VA = "0x7BBBE69970")]
		public UIHudSkillStrengthenArmorController()
		{
		}

		// Token: 0x04009471 RID: 38001
		[Token(Token = "0x4009471")]
		[FieldOffset(Offset = "0x58")]
		private UIHudSkillStrengthenArmorView m_View;
	}
}
