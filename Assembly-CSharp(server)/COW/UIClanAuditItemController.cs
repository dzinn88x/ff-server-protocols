using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001716 RID: 5910
	[Token(Token = "0x2001716")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F16FC", Offset = "0x10F16FC")]
	public class UIClanAuditItemController : UIPopMenuItemBaseController
	{
		// Token: 0x06006E33 RID: 28211 RVA: 0x0001F098 File Offset: 0x0001D298
		[Token(Token = "0x6006E33")]
		[Address(RVA = "0x1BF980C", Offset = "0x1BF980C", VA = "0x7BBC3F980C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006E34 RID: 28212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E34")]
		[Address(RVA = "0x1BF985C", Offset = "0x1BF985C", VA = "0x7BBC3F985C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006E35 RID: 28213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E35")]
		[Address(RVA = "0x1BF9940", Offset = "0x1BF9940", VA = "0x7BBC3F9940", Slot = "28")]
		public override void SetItemData(PopMenuData data)
		{
		}

		// Token: 0x06006E36 RID: 28214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E36")]
		[Address(RVA = "0x1BF99B4", Offset = "0x1BF99B4", VA = "0x7BBC3F99B4")]
		private void SetSelectedState(bool selected)
		{
		}

		// Token: 0x06006E37 RID: 28215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E37")]
		[Address(RVA = "0x1BF9ACC", Offset = "0x1BF9ACC", VA = "0x7BBC3F9ACC")]
		private void OnPopMenuItemClick()
		{
		}

		// Token: 0x06006E38 RID: 28216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E38")]
		[Address(RVA = "0x1BF9BD4", Offset = "0x1BF9BD4", VA = "0x7BBC3F9BD4")]
		public UIClanAuditItemController()
		{
		}

		// Token: 0x040088EC RID: 35052
		[Token(Token = "0x40088EC")]
		[FieldOffset(Offset = "0x60")]
		private UIClanAuditItemView m_View;

		// Token: 0x040088ED RID: 35053
		[Token(Token = "0x40088ED")]
		[FieldOffset(Offset = "0x68")]
		private PopMenuData m_Data;
	}
}
