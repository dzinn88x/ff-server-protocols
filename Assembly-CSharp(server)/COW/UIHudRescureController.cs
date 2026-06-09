using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200194F RID: 6479
	[Token(Token = "0x200194F")]
	internal class UIHudRescureController : UIBaseController
	{
		// Token: 0x06008375 RID: 33653 RVA: 0x00023B38 File Offset: 0x00021D38
		[Token(Token = "0x6008375")]
		[Address(RVA = "0x17F39BC", Offset = "0x17F39BC", VA = "0x7BBBFF39BC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008376 RID: 33654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008376")]
		[Address(RVA = "0x17F3A0C", Offset = "0x17F3A0C", VA = "0x7BBBFF3A0C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008377 RID: 33655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008377")]
		[Address(RVA = "0x17F3CE0", Offset = "0x17F3CE0", VA = "0x7BBBFF3CE0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008378 RID: 33656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008378")]
		[Address(RVA = "0x17F3ED4", Offset = "0x17F3ED4", VA = "0x7BBBFF3ED4")]
		private void Update()
		{
		}

		// Token: 0x06008379 RID: 33657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008379")]
		[Address(RVA = "0x17F52A0", Offset = "0x17F52A0", VA = "0x7BBBFF52A0")]
		public void ModifyRescurePos(Vector3 pos)
		{
		}

		// Token: 0x0600837A RID: 33658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600837A")]
		[Address(RVA = "0x17F5374", Offset = "0x17F5374", VA = "0x7BBBFF5374")]
		public void SetChangePos(Vector3 pos)
		{
		}

		// Token: 0x0600837B RID: 33659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600837B")]
		[Address(RVA = "0x17F5380", Offset = "0x17F5380", VA = "0x7BBBFF5380")]
		private void OnRescureBtnClicked()
		{
		}

		// Token: 0x0600837C RID: 33660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600837C")]
		[Address(RVA = "0x17F55A8", Offset = "0x17F55A8", VA = "0x7BBBFF55A8")]
		private void OnPreparationCancel(params object[] param)
		{
		}

		// Token: 0x0600837D RID: 33661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600837D")]
		[Address(RVA = "0x17F56D0", Offset = "0x17F56D0", VA = "0x7BBBFF56D0")]
		private void OnHudSettingChanged(params object[] param)
		{
		}

		// Token: 0x0600837E RID: 33662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600837E")]
		[Address(RVA = "0x17F57C8", Offset = "0x17F57C8", VA = "0x7BBBFF57C8")]
		private void OnDecreaseInPreparation(params object[] data)
		{
		}

		// Token: 0x0600837F RID: 33663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600837F")]
		[Address(RVA = "0x17F5890", Offset = "0x17F5890", VA = "0x7BBBFF5890")]
		public UIHudRescureController()
		{
		}

		// Token: 0x04009444 RID: 37956
		[Token(Token = "0x4009444")]
		[FieldOffset(Offset = "0x58")]
		private UIHudRescureView m_View;

		// Token: 0x04009445 RID: 37957
		[Token(Token = "0x4009445")]
		[FieldOffset(Offset = "0x60")]
		private {QAb\u0082~u m_TargetResureID;

		// Token: 0x04009446 RID: 37958
		[Token(Token = "0x4009446")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 diffPos;

		// Token: 0x04009447 RID: 37959
		[Token(Token = "0x4009447")]
		[FieldOffset(Offset = "0x84")]
		private Vector3 currentPos;

		// Token: 0x04009448 RID: 37960
		[Token(Token = "0x4009448")]
		[FieldOffset(Offset = "0x90")]
		private Transform tr;

		// Token: 0x04009449 RID: 37961
		[Token(Token = "0x4009449")]
		[FieldOffset(Offset = "0x98")]
		private bool m_IsRescuring;
	}
}
