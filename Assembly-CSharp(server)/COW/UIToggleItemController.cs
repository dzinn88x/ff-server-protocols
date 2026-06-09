using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BB3 RID: 7091
	[Token(Token = "0x2001BB3")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FAA4C", Offset = "0x10FAA4C")]
	public class UIToggleItemController : UIBaseController
	{
		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06009906 RID: 39174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A4B")]
		protected UILabel m_SelectLabel
		{
			[Token(Token = "0x6009906")]
			[Address(RVA = "0x1F548DC", Offset = "0x1F548DC", VA = "0x7BBC7548DC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06009907 RID: 39175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A4C")]
		protected UILabel m_UnSelectLabel
		{
			[Token(Token = "0x6009907")]
			[Address(RVA = "0x1F54908", Offset = "0x1F54908", VA = "0x7BBC754908")]
			get
			{
				return null;
			}
		}

		// Token: 0x06009908 RID: 39176 RVA: 0x000284D0 File Offset: 0x000266D0
		[Token(Token = "0x6009908")]
		[Address(RVA = "0x1F54934", Offset = "0x1F54934", VA = "0x7BBC754934")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009909 RID: 39177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009909")]
		[Address(RVA = "0x1F54984", Offset = "0x1F54984", VA = "0x7BBC754984", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600990A RID: 39178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600990A")]
		[Address(RVA = "0x1F54A68", Offset = "0x1F54A68", VA = "0x7BBC754A68", Slot = "28")]
		public virtual void SetData(PopMenuData data, int groupID)
		{
		}

		// Token: 0x0600990B RID: 39179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600990B")]
		[Address(RVA = "0x1F54B88", Offset = "0x1F54B88", VA = "0x7BBC754B88")]
		public void RefreshToggleValue()
		{
		}

		// Token: 0x0600990C RID: 39180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600990C")]
		[Address(RVA = "0x1F54BF0", Offset = "0x1F54BF0", VA = "0x7BBC754BF0")]
		private void OnChange()
		{
		}

		// Token: 0x0600990D RID: 39181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600990D")]
		[Address(RVA = "0x1F54D0C", Offset = "0x1F54D0C", VA = "0x7BBC754D0C")]
		public UIToggleItemController()
		{
		}

		// Token: 0x0400A094 RID: 41108
		[Token(Token = "0x400A094")]
		[FieldOffset(Offset = "0x58")]
		private UIToggleItemView m_View;

		// Token: 0x0400A095 RID: 41109
		[Token(Token = "0x400A095")]
		[FieldOffset(Offset = "0x60")]
		private PopMenuData m_Data;
	}
}
