using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200188D RID: 6285
	[Token(Token = "0x200188D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F456C", Offset = "0x10F456C")]
	internal class UIHudCancelController : UIHudButtonBaseController
	{
		// Token: 0x06007C7B RID: 31867 RVA: 0x00022338 File Offset: 0x00020538
		[Token(Token = "0x6007C7B")]
		[Address(RVA = "0x19D0B34", Offset = "0x19D0B34", VA = "0x7BBC1D0B34")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007C7C RID: 31868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C7C")]
		[Address(RVA = "0x19D0B84", Offset = "0x19D0B84", VA = "0x7BBC1D0B84", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007C7D RID: 31869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C7D")]
		[Address(RVA = "0x19D0C90", Offset = "0x19D0C90", VA = "0x7BBC1D0C90", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007C7E RID: 31870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C7E")]
		[Address(RVA = "0x19D0D58", Offset = "0x19D0D58", VA = "0x7BBC1D0D58")]
		private void OnChangeVisible(params object[] param)
		{
		}

		// Token: 0x06007C7F RID: 31871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007C7F")]
		[Address(RVA = "0x19D0F04", Offset = "0x19D0F04", VA = "0x7BBC1D0F04", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x06007C80 RID: 31872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C80")]
		[Address(RVA = "0x19D0F4C", Offset = "0x19D0F4C", VA = "0x7BBC1D0F4C")]
		public void SetDefaultPos(Vector3 pos)
		{
		}

		// Token: 0x06007C81 RID: 31873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C81")]
		[Address(RVA = "0x19D0F58", Offset = "0x19D0F58", VA = "0x7BBC1D0F58")]
		public UIHudCancelController()
		{
		}

		// Token: 0x04009061 RID: 36961
		[Token(Token = "0x4009061")]
		[FieldOffset(Offset = "0x60")]
		private UIHudCancelView m_View;

		// Token: 0x04009062 RID: 36962
		[Token(Token = "0x4009062")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 m_pos;
	}
}
