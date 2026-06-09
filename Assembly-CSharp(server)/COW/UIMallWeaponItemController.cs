using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020015A7 RID: 5543
	[Token(Token = "0x20015A7")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EEFDC", Offset = "0x10EEFDC")]
	public class UIMallWeaponItemController : UIMallCDNItemController
	{
		// Token: 0x06006198 RID: 24984 RVA: 0x0001C1A0 File Offset: 0x0001A3A0
		[Token(Token = "0x6006198")]
		[Address(RVA = "0x1DF403C", Offset = "0x1DF403C", VA = "0x7BBC5F403C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006199 RID: 24985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006199")]
		[Address(RVA = "0x1DF408C", Offset = "0x1DF408C", VA = "0x7BBC5F408C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600619A RID: 24986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600619A")]
		[Address(RVA = "0x1DF40F4", Offset = "0x1DF40F4", VA = "0x7BBC5F40F4")]
		private void InitCommonWidget()
		{
		}

		// Token: 0x0600619B RID: 24987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600619B")]
		[Address(RVA = "0x1DF41C0", Offset = "0x1DF41C0", VA = "0x7BBC5F41C0", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x0600619C RID: 24988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600619C")]
		[Address(RVA = "0x1DF42BC", Offset = "0x1DF42BC", VA = "0x7BBC5F42BC", Slot = "39")]
		protected override void RefreshItemView()
		{
		}

		// Token: 0x0600619D RID: 24989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600619D")]
		[Address(RVA = "0x1DF4664", Offset = "0x1DF4664", VA = "0x7BBC5F4664", Slot = "34")]
		protected override void SendItemClickEvent()
		{
		}

		// Token: 0x0600619E RID: 24990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600619E")]
		[Address(RVA = "0x1DF4814", Offset = "0x1DF4814", VA = "0x7BBC5F4814", Slot = "35")]
		protected override void SendClothClickEvent()
		{
		}

		// Token: 0x0600619F RID: 24991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600619F")]
		[Address(RVA = "0x1DF49E0", Offset = "0x1DF49E0", VA = "0x7BBC5F49E0", Slot = "40")]
		protected override void ResetState()
		{
		}

		// Token: 0x060061A0 RID: 24992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061A0")]
		[Address(RVA = "0x1DF4BC8", Offset = "0x1DF4BC8", VA = "0x7BBC5F4BC8", Slot = "47")]
		protected override void OnStartToggleMove()
		{
		}

		// Token: 0x060061A1 RID: 24993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061A1")]
		[Address(RVA = "0x1DF4C58", Offset = "0x1DF4C58", VA = "0x7BBC5F4C58", Slot = "48")]
		protected override void OnFinishToggleMove()
		{
		}

		// Token: 0x060061A2 RID: 24994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061A2")]
		[Address(RVA = "0x1DF4D00", Offset = "0x1DF4D00", VA = "0x7BBC5F4D00")]
		public void HideEffect()
		{
		}

		// Token: 0x060061A3 RID: 24995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061A3")]
		[Address(RVA = "0x1DF4D90", Offset = "0x1DF4D90", VA = "0x7BBC5F4D90")]
		public UIMallWeaponItemController()
		{
		}

		// Token: 0x0400815D RID: 33117
		[Token(Token = "0x400815D")]
		[FieldOffset(Offset = "0x230")]
		private UIMallWeaponItemView m_View;

		// Token: 0x0400815E RID: 33118
		[Token(Token = "0x400815E")]
		[FieldOffset(Offset = "0x238")]
		private StoreDesc m_Info;
	}
}
