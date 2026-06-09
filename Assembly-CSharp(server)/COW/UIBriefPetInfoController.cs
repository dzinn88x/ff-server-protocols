using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020016EC RID: 5868
	[Token(Token = "0x20016EC")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F106C", Offset = "0x10F106C")]
	internal class UIBriefPetInfoController : UIBaseController
	{
		// Token: 0x06006CD2 RID: 27858 RVA: 0x0001EB28 File Offset: 0x0001CD28
		[Token(Token = "0x6006CD2")]
		[Address(RVA = "0x1C1B53C", Offset = "0x1C1B53C", VA = "0x7BBC41B53C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006CD3 RID: 27859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CD3")]
		[Address(RVA = "0x1C1B58C", Offset = "0x1C1B58C", VA = "0x7BBC41B58C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006CD4 RID: 27860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CD4")]
		[Address(RVA = "0x1C1B618", Offset = "0x1C1B618", VA = "0x7BBC41B618")]
		public void SetNickName(string nickname, uint pet_id, uint lv)
		{
		}

		// Token: 0x06006CD5 RID: 27861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CD5")]
		[Address(RVA = "0x1C1B8E4", Offset = "0x1C1B8E4", VA = "0x7BBC41B8E4")]
		public UIBriefPetInfoController()
		{
		}

		// Token: 0x04008851 RID: 34897
		[Token(Token = "0x4008851")]
		[FieldOffset(Offset = "0x58")]
		private UIBriefProfileInfoView m_View;
	}
}
