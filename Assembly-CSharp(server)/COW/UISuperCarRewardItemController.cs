using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020013C3 RID: 5059
	[Token(Token = "0x20013C3")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EBDE0", Offset = "0x10EBDE0")]
	public class UISuperCarRewardItemController : UIBaseController
	{
		// Token: 0x060052A9 RID: 21161 RVA: 0x00018CC0 File Offset: 0x00016EC0
		[Token(Token = "0x60052A9")]
		[Address(RVA = "0x214A8C8", Offset = "0x214A8C8", VA = "0x7BBC94A8C8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060052AA RID: 21162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052AA")]
		[Address(RVA = "0x214A918", Offset = "0x214A918", VA = "0x7BBC94A918", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060052AB RID: 21163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052AB")]
		[Address(RVA = "0x214A9DC", Offset = "0x214A9DC", VA = "0x7BBC94A9DC", Slot = "28")]
		protected virtual object CreateView()
		{
			return null;
		}

		// Token: 0x060052AC RID: 21164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052AC")]
		[Address(RVA = "0x214AA2C", Offset = "0x214AA2C", VA = "0x7BBC94AA2C")]
		public void SetData(uint id, AwardDesc award)
		{
		}

		// Token: 0x060052AD RID: 21165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052AD")]
		[Address(RVA = "0x214ACC0", Offset = "0x214ACC0", VA = "0x7BBC94ACC0")]
		private void CreateAwardItems(AwardDesc awards)
		{
		}

		// Token: 0x060052AE RID: 21166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052AE")]
		[Address(RVA = "0x214AE5C", Offset = "0x214AE5C", VA = "0x7BBC94AE5C")]
		public UISuperCarRewardItemController()
		{
		}

		// Token: 0x0400788B RID: 30859
		[Token(Token = "0x400788B")]
		[FieldOffset(Offset = "0x58")]
		private UISuperCarRewardItemView m_View;
	}
}
