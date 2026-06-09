using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020016CB RID: 5835
	[Token(Token = "0x20016CB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F0CE4", Offset = "0x10F0CE4")]
	public class UIAvatarSkillTipsItemController : UIBaseController
	{
		// Token: 0x06006B48 RID: 27464 RVA: 0x0001E618 File Offset: 0x0001C818
		[Token(Token = "0x6006B48")]
		[Address(RVA = "0x1E501DC", Offset = "0x1E501DC", VA = "0x7BBC6501DC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006B49 RID: 27465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B49")]
		[Address(RVA = "0x1E5022C", Offset = "0x1E5022C", VA = "0x7BBC65022C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006B4A RID: 27466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B4A")]
		[Address(RVA = "0x1E4F65C", Offset = "0x1E4F65C", VA = "0x7BBC64F65C")]
		public void RefreshData(List<string> datalist)
		{
		}

		// Token: 0x06006B4B RID: 27467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B4B")]
		[Address(RVA = "0x1E4F8DC", Offset = "0x1E4F8DC", VA = "0x7BBC64F8DC")]
		public void RefreshCount(int count)
		{
		}

		// Token: 0x06006B4C RID: 27468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B4C")]
		[Address(RVA = "0x1E50290", Offset = "0x1E50290", VA = "0x7BBC650290")]
		public UIAvatarSkillTipsItemController()
		{
		}

		// Token: 0x04008741 RID: 34625
		[Token(Token = "0x4008741")]
		[FieldOffset(Offset = "0x58")]
		private UIAvatarSkillTipsItemView m_View;

		// Token: 0x04008742 RID: 34626
		[Token(Token = "0x4008742")]
		[FieldOffset(Offset = "0x60")]
		private uint MaxDataListLength;
	}
}
