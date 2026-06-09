using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000EE6 RID: 3814
	[Token(Token = "0x2000EE6")]
	public class LoadingProcess
	{
		// Token: 0x06003525 RID: 13605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003525")]
		[Address(RVA = "0x21209EC", Offset = "0x21209EC", VA = "0x7BBC9209EC")]
		public void StartProcess()
		{
		}

		// Token: 0x06003526 RID: 13606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003526")]
		[Address(RVA = "0x2120A0C", Offset = "0x2120A0C", VA = "0x7BBC920A0C")]
		public void UpdateProcess()
		{
		}

		// Token: 0x06003527 RID: 13607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003527")]
		[Address(RVA = "0x2120A48", Offset = "0x2120A48", VA = "0x7BBC920A48")]
		public void CleanProcess()
		{
		}

		// Token: 0x06003528 RID: 13608 RVA: 0x0000FF78 File Offset: 0x0000E178
		[Token(Token = "0x6003528")]
		[Address(RVA = "0x2120A60", Offset = "0x2120A60", VA = "0x7BBC920A60", Slot = "4")]
		public virtual bool IsMainProcess()
		{
			return default(bool);
		}

		// Token: 0x06003529 RID: 13609 RVA: 0x0000FF90 File Offset: 0x0000E190
		[Token(Token = "0x6003529")]
		[Address(RVA = "0x2120A68", Offset = "0x2120A68", VA = "0x7BBC920A68")]
		public bool IsFinished()
		{
			return default(bool);
		}

		// Token: 0x0600352A RID: 13610 RVA: 0x0000FFA8 File Offset: 0x0000E1A8
		[Token(Token = "0x600352A")]
		[Address(RVA = "0x2120A78", Offset = "0x2120A78", VA = "0x7BBC920A78")]
		public bool HasException()
		{
			return default(bool);
		}

		// Token: 0x0600352B RID: 13611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600352B")]
		[Address(RVA = "0x2120A88", Offset = "0x2120A88", VA = "0x7BBC920A88", Slot = "5")]
		protected virtual void OnStartProcess()
		{
		}

		// Token: 0x0600352C RID: 13612 RVA: 0x0000FFC0 File Offset: 0x0000E1C0
		[Token(Token = "0x600352C")]
		[Address(RVA = "0x2120A8C", Offset = "0x2120A8C", VA = "0x7BBC920A8C", Slot = "6")]
		protected virtual LoadingProcess.EProcessStatus OnUpdateProcess()
		{
			return LoadingProcess.EProcessStatus.NotStarted;
		}

		// Token: 0x0600352D RID: 13613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600352D")]
		[Address(RVA = "0x2120A94", Offset = "0x2120A94", VA = "0x7BBC920A94", Slot = "7")]
		protected virtual void OnCleanProcess()
		{
		}

		// Token: 0x0600352E RID: 13614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600352E")]
		[Address(RVA = "0x2120A98", Offset = "0x2120A98", VA = "0x7BBC920A98")]
		public LoadingProcess()
		{
		}

		// Token: 0x04004894 RID: 18580
		[Token(Token = "0x4004894")]
		[FieldOffset(Offset = "0x10")]
		private LoadingProcess.EProcessStatus m_Status;

		// Token: 0x02000EE7 RID: 3815
		[Token(Token = "0x2000EE7")]
		public enum EProcessStatus
		{
			// Token: 0x04004896 RID: 18582
			[Token(Token = "0x4004896")]
			NotStarted,
			// Token: 0x04004897 RID: 18583
			[Token(Token = "0x4004897")]
			Running,
			// Token: 0x04004898 RID: 18584
			[Token(Token = "0x4004898")]
			Finished,
			// Token: 0x04004899 RID: 18585
			[Token(Token = "0x4004899")]
			Exception
		}
	}
}
