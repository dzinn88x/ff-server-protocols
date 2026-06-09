using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001972 RID: 6514
	[Token(Token = "0x2001972")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6524", Offset = "0x10F6524")]
	internal class UIHUDTeamKillController : UIBaseController
	{
		// Token: 0x060084A1 RID: 33953 RVA: 0x00023FA0 File Offset: 0x000221A0
		[Token(Token = "0x60084A1")]
		[Address(RVA = "0x1D4F0CC", Offset = "0x1D4F0CC", VA = "0x7BBC54F0CC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060084A2 RID: 33954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084A2")]
		[Address(RVA = "0x1D4F11C", Offset = "0x1D4F11C", VA = "0x7BBC54F11C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060084A3 RID: 33955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084A3")]
		[Address(RVA = "0x1D4F180", Offset = "0x1D4F180", VA = "0x7BBC54F180")]
		public void Show(float showTime)
		{
		}

		// Token: 0x060084A4 RID: 33956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084A4")]
		[Address(RVA = "0x1D4F260", Offset = "0x1D4F260", VA = "0x7BBC54F260")]
		public UIHUDTeamKillController()
		{
		}

		// Token: 0x060084A5 RID: 33957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084A5")]
		[Address(RVA = "0x1D4F268", Offset = "0x1D4F268", VA = "0x7BBC54F268")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1143374", Offset = "0x1143374")]
		private void <Show>b__3_0()
		{
		}

		// Token: 0x040094BF RID: 38079
		[Token(Token = "0x40094BF")]
		[FieldOffset(Offset = "0x58")]
		private UIHUDTeamKillView m_View;
	}
}
