using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BB4 RID: 7092
	[Token(Token = "0x2001BB4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FAA84", Offset = "0x10FAA84")]
	public class UIToggleSpriteItemController : UIBaseController
	{
		// Token: 0x0600990E RID: 39182 RVA: 0x000284E8 File Offset: 0x000266E8
		[Token(Token = "0x600990E")]
		[Address(RVA = "0x1F54E34", Offset = "0x1F54E34", VA = "0x7BBC754E34")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600990F RID: 39183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600990F")]
		[Address(RVA = "0x1F54E84", Offset = "0x1F54E84", VA = "0x7BBC754E84", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009910 RID: 39184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009910")]
		[Address(RVA = "0x1F54F68", Offset = "0x1F54F68", VA = "0x7BBC754F68", Slot = "28")]
		public virtual void SetData(PopMenuData data, int groupID)
		{
		}

		// Token: 0x06009911 RID: 39185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009911")]
		[Address(RVA = "0x1F55000", Offset = "0x1F55000", VA = "0x7BBC755000")]
		public void SetSprite(string name)
		{
		}

		// Token: 0x06009912 RID: 39186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009912")]
		[Address(RVA = "0x1F55084", Offset = "0x1F55084", VA = "0x7BBC755084")]
		public void RefreshToggleValue()
		{
		}

		// Token: 0x06009913 RID: 39187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009913")]
		[Address(RVA = "0x1F550EC", Offset = "0x1F550EC", VA = "0x7BBC7550EC")]
		private void OnChange()
		{
		}

		// Token: 0x06009914 RID: 39188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009914")]
		[Address(RVA = "0x1F55208", Offset = "0x1F55208", VA = "0x7BBC755208")]
		public UIToggleSpriteItemController()
		{
		}

		// Token: 0x0400A096 RID: 41110
		[Token(Token = "0x400A096")]
		[FieldOffset(Offset = "0x58")]
		private UIToggleSpriteItemView m_View;

		// Token: 0x0400A097 RID: 41111
		[Token(Token = "0x400A097")]
		[FieldOffset(Offset = "0x60")]
		private PopMenuData m_Data;
	}
}
