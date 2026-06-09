using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001AF6 RID: 6902
	[Token(Token = "0x2001AF6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F8FBC", Offset = "0x10F8FBC")]
	public class UIPetLevelUpController : UIPopupWindowController
	{
		// Token: 0x0600928E RID: 37518 RVA: 0x00027048 File Offset: 0x00025248
		[Token(Token = "0x600928E")]
		[Address(RVA = "0x20E0438", Offset = "0x20E0438", VA = "0x7BBC8E0438")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600928F RID: 37519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600928F")]
		[Address(RVA = "0x20E0488", Offset = "0x20E0488", VA = "0x7BBC8E0488", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009290 RID: 37520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009290")]
		[Address(RVA = "0x20E056C", Offset = "0x20E056C", VA = "0x7BBC8E056C")]
		public void SetLevelData(uint before, uint after, uint pet_id)
		{
		}

		// Token: 0x06009291 RID: 37521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009291")]
		[Address(RVA = "0x20E06E8", Offset = "0x20E06E8", VA = "0x7BBC8E06E8")]
		private void OnOKClick()
		{
		}

		// Token: 0x06009292 RID: 37522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009292")]
		[Address(RVA = "0x20E085C", Offset = "0x20E085C", VA = "0x7BBC8E085C")]
		public UIPetLevelUpController()
		{
		}

		// Token: 0x04009D01 RID: 40193
		[Token(Token = "0x4009D01")]
		[FieldOffset(Offset = "0x98")]
		private UIPetLevelUpView m_View;
	}
}
