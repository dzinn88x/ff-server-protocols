using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B21 RID: 6945
	[Token(Token = "0x2001B21")]
	public class UIProfileDocumentRuleItemController : UIBaseController
	{
		// Token: 0x060094C1 RID: 38081 RVA: 0x00027528 File Offset: 0x00025728
		[Token(Token = "0x60094C1")]
		[Address(RVA = "0x1B6660C", Offset = "0x1B6660C", VA = "0x7BBC36660C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060094C2 RID: 38082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094C2")]
		[Address(RVA = "0x1B6665C", Offset = "0x1B6665C", VA = "0x7BBC36665C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060094C3 RID: 38083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094C3")]
		[Address(RVA = "0x1B66748", Offset = "0x1B66748", VA = "0x7BBC366748")]
		public void SetType(UIProfileDocumentRuleItemController.ProfileDocumentRuleType ruleType)
		{
		}

		// Token: 0x060094C4 RID: 38084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094C4")]
		[Address(RVA = "0x1B6695C", Offset = "0x1B6695C", VA = "0x7BBC36695C")]
		public UIProfileDocumentRuleItemController()
		{
		}

		// Token: 0x04009E3A RID: 40506
		[Token(Token = "0x4009E3A")]
		[FieldOffset(Offset = "0x58")]
		public int AdIndex;

		// Token: 0x04009E3B RID: 40507
		[Token(Token = "0x4009E3B")]
		[FieldOffset(Offset = "0x5C")]
		private UIProfileDocumentRuleItemController.ProfileDocumentRuleType m_RuleType;

		// Token: 0x04009E3C RID: 40508
		[Token(Token = "0x4009E3C")]
		[FieldOffset(Offset = "0x60")]
		private UIProfileDocumentRuleItemView m_View;

		// Token: 0x02001B22 RID: 6946
		[Token(Token = "0x2001B22")]
		public enum ProfileDocumentRuleType
		{
			// Token: 0x04009E3E RID: 40510
			[Token(Token = "0x4009E3E")]
			BR,
			// Token: 0x04009E3F RID: 40511
			[Token(Token = "0x4009E3F")]
			CS
		}
	}
}
