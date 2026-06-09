using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200195A RID: 6490
	[Token(Token = "0x200195A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6184", Offset = "0x10F6184")]
	internal class UIHudSkillKnockDownBleedController : UIBaseController
	{
		// Token: 0x060083CA RID: 33738 RVA: 0x00023CB8 File Offset: 0x00021EB8
		[Token(Token = "0x60083CA")]
		[Address(RVA = "0x1669624", Offset = "0x1669624", VA = "0x7BBBE69624")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060083CB RID: 33739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083CB")]
		[Address(RVA = "0x1669674", Offset = "0x1669674", VA = "0x7BBBE69674", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060083CC RID: 33740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083CC")]
		[Address(RVA = "0x16696E8", Offset = "0x16696E8", VA = "0x7BBBE696E8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060083CD RID: 33741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083CD")]
		[Address(RVA = "0x16696F0", Offset = "0x16696F0", VA = "0x7BBBE696F0")]
		public UIHudSkillKnockDownBleedController()
		{
		}

		// Token: 0x04009470 RID: 38000
		[Token(Token = "0x4009470")]
		[FieldOffset(Offset = "0x58")]
		private UIHudSkillKnockDownBleedView m_View;
	}
}
