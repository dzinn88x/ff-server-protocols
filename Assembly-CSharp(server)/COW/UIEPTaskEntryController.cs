using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020014FB RID: 5371
	[Token(Token = "0x20014FB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EDEA4", Offset = "0x10EDEA4")]
	public class UIEPTaskEntryController : UIBaseController
	{
		// Token: 0x06005C21 RID: 23585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C21")]
		[Address(RVA = "0x1ACD848", Offset = "0x1ACD848", VA = "0x7BBC2CD848", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005C22 RID: 23586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C22")]
		[Address(RVA = "0x1ACDC90", Offset = "0x1ACDC90", VA = "0x7BBC2CDC90")]
		public GameObject GetIconObj()
		{
			return null;
		}

		// Token: 0x06005C23 RID: 23587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C23")]
		[Address(RVA = "0x1ACDCD0", Offset = "0x1ACDCD0", VA = "0x7BBC2CDCD0")]
		public GameObject GetProgressObj()
		{
			return null;
		}

		// Token: 0x06005C24 RID: 23588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C24")]
		[Address(RVA = "0x1ACDD44", Offset = "0x1ACDD44", VA = "0x7BBC2CDD44", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005C25 RID: 23589 RVA: 0x0001ADD8 File Offset: 0x00018FD8
		[Token(Token = "0x6005C25")]
		[Address(RVA = "0x1ACDE64", Offset = "0x1ACDE64", VA = "0x7BBC2CDE64")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005C26 RID: 23590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C26")]
		[Address(RVA = "0x1ACDEB4", Offset = "0x1ACDEB4", VA = "0x7BBC2CDEB4")]
		private void OnEntryClick()
		{
		}

		// Token: 0x06005C27 RID: 23591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C27")]
		[Address(RVA = "0x1ACDABC", Offset = "0x1ACDABC", VA = "0x7BBC2CDABC")]
		private void SetEpEntranceTips()
		{
		}

		// Token: 0x06005C28 RID: 23592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C28")]
		[Address(RVA = "0x1ACE168", Offset = "0x1ACE168", VA = "0x7BBC2CE168")]
		private void RefreshProcessBar()
		{
		}

		// Token: 0x06005C29 RID: 23593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C29")]
		[Address(RVA = "0x1ACE1E8", Offset = "0x1ACE1E8", VA = "0x7BBC2CE1E8")]
		private void SetRedPointState(params object[] data)
		{
		}

		// Token: 0x06005C2A RID: 23594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C2A")]
		[Address(RVA = "0x1ACE2B8", Offset = "0x1ACE2B8", VA = "0x7BBC2CE2B8")]
		private void OnEPProcessUpdate(params object[] data)
		{
		}

		// Token: 0x06005C2B RID: 23595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C2B")]
		[Address(RVA = "0x1ACE2BC", Offset = "0x1ACE2BC", VA = "0x7BBC2CE2BC")]
		public UIEPTaskEntryController()
		{
		}

		// Token: 0x04007E5F RID: 32351
		[Token(Token = "0x4007E5F")]
		[FieldOffset(Offset = "0x58")]
		private UIEPTaskEntryView m_View;

		// Token: 0x04007E60 RID: 32352
		[Token(Token = "0x4007E60")]
		[FieldOffset(Offset = "0x60")]
		private UIModelElitePass m_Model;

		// Token: 0x04007E61 RID: 32353
		[Token(Token = "0x4007E61")]
		private const string KEY_NEW_TAG = "EPTaskEntry_NewTag_";
	}
}
