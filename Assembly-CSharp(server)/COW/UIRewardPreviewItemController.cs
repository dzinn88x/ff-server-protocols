using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B5A RID: 7002
	[Token(Token = "0x2001B5A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9D1C", Offset = "0x10F9D1C")]
	public class UIRewardPreviewItemController : UIBaseController
	{
		// Token: 0x06009688 RID: 38536 RVA: 0x00027C90 File Offset: 0x00025E90
		[Token(Token = "0x6009688")]
		[Address(RVA = "0x1E20050", Offset = "0x1E20050", VA = "0x7BBC620050")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009689 RID: 38537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009689")]
		[Address(RVA = "0x1E200A0", Offset = "0x1E200A0", VA = "0x7BBC6200A0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600968A RID: 38538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600968A")]
		[Address(RVA = "0x1E2012C", Offset = "0x1E2012C", VA = "0x7BBC62012C")]
		public void SetViewData(BaseItemInfo desc)
		{
		}

		// Token: 0x0600968B RID: 38539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600968B")]
		[Address(RVA = "0x1E20188", Offset = "0x1E20188", VA = "0x7BBC620188")]
		public UIRewardPreviewItemController()
		{
		}

		// Token: 0x04009F16 RID: 40726
		[Token(Token = "0x4009F16")]
		[FieldOffset(Offset = "0x58")]
		private UIRewardPreviewItemView m_View;
	}
}
