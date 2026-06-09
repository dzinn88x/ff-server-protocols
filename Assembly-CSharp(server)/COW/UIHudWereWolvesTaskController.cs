using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200199B RID: 6555
	[Token(Token = "0x200199B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6B14", Offset = "0x10F6B14")]
	public class UIHudWereWolvesTaskController : UIBaseController
	{
		// Token: 0x0600860C RID: 34316 RVA: 0x00024528 File Offset: 0x00022728
		[Token(Token = "0x600860C")]
		[Address(RVA = "0x1D15C08", Offset = "0x1D15C08", VA = "0x7BBC515C08")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600860D RID: 34317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600860D")]
		[Address(RVA = "0x1D15C58", Offset = "0x1D15C58", VA = "0x7BBC515C58", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600860E RID: 34318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600860E")]
		[Address(RVA = "0x1D15E34", Offset = "0x1D15E34", VA = "0x7BBC515E34", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600860F RID: 34319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600860F")]
		[Address(RVA = "0x1D15F54", Offset = "0x1D15F54", VA = "0x7BBC515F54")]
		private void OnNoTask(params object[] data)
		{
		}

		// Token: 0x06008610 RID: 34320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008610")]
		[Address(RVA = "0x1D15FF4", Offset = "0x1D15FF4", VA = "0x7BBC515FF4")]
		private void OnBtnCloseClick()
		{
		}

		// Token: 0x06008611 RID: 34321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008611")]
		[Address(RVA = "0x1D16140", Offset = "0x1D16140", VA = "0x7BBC516140", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06008612 RID: 34322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008612")]
		[Address(RVA = "0x1D16244", Offset = "0x1D16244", VA = "0x7BBC516244")]
		private void OnTaskComplete()
		{
		}

		// Token: 0x06008613 RID: 34323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008613")]
		[Address(RVA = "0x1D16424", Offset = "0x1D16424", VA = "0x7BBC516424")]
		private void OnTaskCompletePost()
		{
		}

		// Token: 0x06008614 RID: 34324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008614")]
		[Address(RVA = "0x1D16594", Offset = "0x1D16594", VA = "0x7BBC516594")]
		private void OnBtnTaskClick(params object[] data)
		{
		}

		// Token: 0x06008615 RID: 34325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008615")]
		[Address(RVA = "0x1D16680", Offset = "0x1D16680", VA = "0x7BBC516680")]
		private void CreateTask()
		{
		}

		// Token: 0x06008616 RID: 34326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008616")]
		[Address(RVA = "0x1D16B38", Offset = "0x1D16B38", VA = "0x7BBC516B38")]
		public void SetData(uint uniqueId)
		{
		}

		// Token: 0x06008617 RID: 34327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008617")]
		[Address(RVA = "0x1D16428", Offset = "0x1D16428", VA = "0x7BBC516428")]
		public void CloseTask()
		{
		}

		// Token: 0x06008618 RID: 34328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008618")]
		[Address(RVA = "0x1D16B40", Offset = "0x1D16B40", VA = "0x7BBC516B40")]
		public UIHudWereWolvesTaskController()
		{
		}

		// Token: 0x04009567 RID: 38247
		[Token(Token = "0x4009567")]
		[FieldOffset(Offset = "0x58")]
		private UIHudWereWolvesTaskView m_View;

		// Token: 0x04009568 RID: 38248
		[Token(Token = "0x4009568")]
		[FieldOffset(Offset = "0x60")]
		private uint _uniqueId;

		// Token: 0x04009569 RID: 38249
		[Token(Token = "0x4009569")]
		[FieldOffset(Offset = "0x64")]
		private bool canDoForbid;

		// Token: 0x0400956A RID: 38250
		[Token(Token = "0x400956A")]
		[FieldOffset(Offset = "0x65")]
		private bool showForbid;

		// Token: 0x0400956B RID: 38251
		[Token(Token = "0x400956B")]
		[FieldOffset(Offset = "0x68")]
		private BaseTask m_task;
	}
}
