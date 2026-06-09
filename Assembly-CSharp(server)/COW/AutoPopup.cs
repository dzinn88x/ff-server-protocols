using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW
{
	// Token: 0x02001320 RID: 4896
	[Token(Token = "0x2001320")]
	public class AutoPopup : MonoBehaviour
	{
		// Token: 0x06004DAB RID: 19883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DAB")]
		[Address(RVA = "0x1555FE8", Offset = "0x1555FE8", VA = "0x7BBBD55FE8")]
		public void StartTask()
		{
		}

		// Token: 0x06004DAC RID: 19884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DAC")]
		[Address(RVA = "0x1555FF4", Offset = "0x1555FF4", VA = "0x7BBBD55FF4")]
		public void AddTask(AutoPopupTask task)
		{
		}

		// Token: 0x06004DAD RID: 19885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DAD")]
		[Address(RVA = "0x15560FC", Offset = "0x15560FC", VA = "0x7BBBD560FC")]
		private void Update()
		{
		}

		// Token: 0x06004DAE RID: 19886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DAE")]
		[Address(RVA = "0x1556400", Offset = "0x1556400", VA = "0x7BBBD56400")]
		public AutoPopup()
		{
		}

		// Token: 0x0400752C RID: 29996
		[Token(Token = "0x400752C")]
		[FieldOffset(Offset = "0x18")]
		private bool m_StartTask;

		// Token: 0x0400752D RID: 29997
		[Token(Token = "0x400752D")]
		[FieldOffset(Offset = "0x20")]
		private List<AutoPopup.ScheduleTask> m_ScheduleTasks;

		// Token: 0x02001321 RID: 4897
		[Token(Token = "0x2001321")]
		public enum TaskState
		{
			// Token: 0x0400752F RID: 29999
			[Token(Token = "0x400752F")]
			None,
			// Token: 0x04007530 RID: 30000
			[Token(Token = "0x4007530")]
			WatingData,
			// Token: 0x04007531 RID: 30001
			[Token(Token = "0x4007531")]
			Do,
			// Token: 0x04007532 RID: 30002
			[Token(Token = "0x4007532")]
			WaitingDone,
			// Token: 0x04007533 RID: 30003
			[Token(Token = "0x4007533")]
			Finished
		}

		// Token: 0x02001322 RID: 4898
		[Token(Token = "0x2001322")]
		public class ScheduleTask
		{
			// Token: 0x06004DAF RID: 19887 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004DAF")]
			[Address(RVA = "0x155608C", Offset = "0x155608C", VA = "0x7BBBD5608C")]
			public ScheduleTask()
			{
			}

			// Token: 0x04007534 RID: 30004
			[Token(Token = "0x4007534")]
			[FieldOffset(Offset = "0x10")]
			public AutoPopup.TaskState state;

			// Token: 0x04007535 RID: 30005
			[Token(Token = "0x4007535")]
			[FieldOffset(Offset = "0x18")]
			public List<ServiceMessageTypeHTTP> waitHttpMessages;

			// Token: 0x04007536 RID: 30006
			[Token(Token = "0x4007536")]
			[FieldOffset(Offset = "0x20")]
			public HttpRequest currentWaitHttpRequest;

			// Token: 0x04007537 RID: 30007
			[Token(Token = "0x4007537")]
			[FieldOffset(Offset = "0x28")]
			public AutoPopupTask task;
		}
	}
}
