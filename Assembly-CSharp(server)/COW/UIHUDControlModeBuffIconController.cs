using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001897 RID: 6295
	[Token(Token = "0x2001897")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F46F4", Offset = "0x10F46F4")]
	internal class UIHUDControlModeBuffIconController : UIBaseController
	{
		// Token: 0x06007CC4 RID: 31940 RVA: 0x00022410 File Offset: 0x00020610
		[Token(Token = "0x6007CC4")]
		[Address(RVA = "0x16B83D4", Offset = "0x16B83D4", VA = "0x7BBBEB83D4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007CC5 RID: 31941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CC5")]
		[Address(RVA = "0x16B8424", Offset = "0x16B8424", VA = "0x7BBBEB8424", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007CC6 RID: 31942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CC6")]
		[Address(RVA = "0x16B8488", Offset = "0x16B8488", VA = "0x7BBBEB8488")]
		public void StartShow(float time)
		{
		}

		// Token: 0x06007CC7 RID: 31943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CC7")]
		[Address(RVA = "0x16B870C", Offset = "0x16B870C", VA = "0x7BBBEB870C")]
		private void Update()
		{
		}

		// Token: 0x06007CC8 RID: 31944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CC8")]
		[Address(RVA = "0x16B8774", Offset = "0x16B8774", VA = "0x7BBBEB8774")]
		public UIHUDControlModeBuffIconController()
		{
		}

		// Token: 0x04009080 RID: 36992
		[Token(Token = "0x4009080")]
		[FieldOffset(Offset = "0x58")]
		private UIHUDControlModeBuffIconView m_View;

		// Token: 0x04009081 RID: 36993
		[Token(Token = "0x4009081")]
		[FieldOffset(Offset = "0x60")]
		private UITimeLabelHelper m_EndTime;
	}
}
