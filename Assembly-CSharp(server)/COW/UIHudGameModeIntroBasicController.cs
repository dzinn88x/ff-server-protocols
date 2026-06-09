using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018C3 RID: 6339
	[Token(Token = "0x20018C3")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4C6C", Offset = "0x10F4C6C")]
	public class UIHudGameModeIntroBasicController : UIBaseController
	{
		// Token: 0x06007E3C RID: 32316 RVA: 0x00022890 File Offset: 0x00020A90
		[Token(Token = "0x6007E3C")]
		[Address(RVA = "0x1C10AF0", Offset = "0x1C10AF0", VA = "0x7BBC410AF0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007E3D RID: 32317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E3D")]
		[Address(RVA = "0x1C10B40", Offset = "0x1C10B40", VA = "0x7BBC410B40", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007E3E RID: 32318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E3E")]
		[Address(RVA = "0x1C10BCC", Offset = "0x1C10BCC", VA = "0x7BBC410BCC")]
		public void ShowDetailInfo(GameModeIntroBasicInfo info, [Optional] Action callback)
		{
		}

		// Token: 0x06007E3F RID: 32319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E3F")]
		[Address(RVA = "0x1C11080", Offset = "0x1C11080", VA = "0x7BBC411080")]
		public UIHudGameModeIntroBasicController()
		{
		}

		// Token: 0x0400919C RID: 37276
		[Token(Token = "0x400919C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private UIHudGameModeIntroBasicView m_View;

		// Token: 0x020018C4 RID: 6340
		[Token(Token = "0x20018C4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F4CA4", Offset = "0x10F4CA4")]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06007E40 RID: 32320 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E40")]
			[Address(RVA = "0x1C11078", Offset = "0x1C11078", VA = "0x7BBC411078")]
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x06007E41 RID: 32321 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E41")]
			[Address(RVA = "0x1C11088", Offset = "0x1C11088", VA = "0x7BBC411088")]
			internal void <ShowDetailInfo>b__0()
			{
			}

			// Token: 0x0400919D RID: 37277
			[Token(Token = "0x400919D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIHudGameModeIntroBasicController <>4__this;

			// Token: 0x0400919E RID: 37278
			[Token(Token = "0x400919E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action callback;
		}
	}
}
