using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018A9 RID: 6313
	[Token(Token = "0x20018A9")]
	public class UIHudDGGScoreInfoController : UIBaseController
	{
		// Token: 0x06007D6F RID: 32111 RVA: 0x00022608 File Offset: 0x00020808
		[Token(Token = "0x6007D6F")]
		[Address(RVA = "0x1AAB404", Offset = "0x1AAB404", VA = "0x7BBC2AB404")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007D70 RID: 32112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D70")]
		[Address(RVA = "0x1AAB454", Offset = "0x1AAB454", VA = "0x7BBC2AB454", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007D71 RID: 32113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D71")]
		[Address(RVA = "0x1AAB6F8", Offset = "0x1AAB6F8", VA = "0x7BBC2AB6F8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007D72 RID: 32114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D72")]
		[Address(RVA = "0x1AAB818", Offset = "0x1AAB818", VA = "0x7BBC2AB818")]
		private void OnScoreChange(object[] data)
		{
		}

		// Token: 0x06007D73 RID: 32115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D73")]
		[Address(RVA = "0x1AAB9E0", Offset = "0x1AAB9E0", VA = "0x7BBC2AB9E0")]
		private void OnLeadingScoreChange(object[] data)
		{
		}

		// Token: 0x06007D74 RID: 32116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D74")]
		[Address(RVA = "0x1AAB694", Offset = "0x1AAB694", VA = "0x7BBC2AB694")]
		private void UpdateScore(int score)
		{
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06007D75 RID: 32117 RVA: 0x00022620 File Offset: 0x00020820
		[Token(Token = "0x17000993")]
		private int CurrentScore
		{
			[Token(Token = "0x6007D75")]
			[Address(RVA = "0x1AAB5D0", Offset = "0x1AAB5D0", VA = "0x7BBC2AB5D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06007D76 RID: 32118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D76")]
		[Address(RVA = "0x1AABAB0", Offset = "0x1AABAB0", VA = "0x7BBC2ABAB0")]
		public UIHudDGGScoreInfoController()
		{
		}

		// Token: 0x040090FF RID: 37119
		[Token(Token = "0x40090FF")]
		[FieldOffset(Offset = "0x58")]
		private UIHudDGGScoreInfoView m_View;
	}
}
