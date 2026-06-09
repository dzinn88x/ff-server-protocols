using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001C08 RID: 7176
	[Token(Token = "0x2001C08")]
	internal class UIHUDWereWolvesPrepareInfoController : UIBaseController
	{
		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06009C24 RID: 39972 RVA: 0x00028F98 File Offset: 0x00027198
		[Token(Token = "0x17000A5D")]
		public float EndTime
		{
			[Token(Token = "0x6009C24")]
			[Address(RVA = "0x1D5A7E0", Offset = "0x1D5A7E0", VA = "0x7BBC55A7E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06009C25 RID: 39973 RVA: 0x00028FB0 File Offset: 0x000271B0
		[Token(Token = "0x6009C25")]
		[Address(RVA = "0x1D5A7E8", Offset = "0x1D5A7E8", VA = "0x7BBC55A7E8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009C26 RID: 39974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C26")]
		[Address(RVA = "0x1D5A838", Offset = "0x1D5A838", VA = "0x7BBC55A838", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009C27 RID: 39975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C27")]
		[Address(RVA = "0x1D5A9A8", Offset = "0x1D5A9A8", VA = "0x7BBC55A9A8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009C28 RID: 39976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C28")]
		[Address(RVA = "0x1D5AA74", Offset = "0x1D5AA74", VA = "0x7BBC55AA74")]
		public void OnCampInfoCome()
		{
		}

		// Token: 0x06009C29 RID: 39977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C29")]
		[Address(RVA = "0x1D5AB1C", Offset = "0x1D5AB1C", VA = "0x7BBC55AB1C")]
		private void OnPhaseEndTimeCome(params object[] param)
		{
		}

		// Token: 0x06009C2A RID: 39978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C2A")]
		[Address(RVA = "0x1D5ADEC", Offset = "0x1D5ADEC", VA = "0x7BBC55ADEC")]
		private void Update()
		{
		}

		// Token: 0x06009C2B RID: 39979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C2B")]
		[Address(RVA = "0x1D5AC08", Offset = "0x1D5AC08", VA = "0x7BBC55AC08")]
		private void UpdateLeftTimeShow()
		{
		}

		// Token: 0x06009C2C RID: 39980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C2C")]
		[Address(RVA = "0x1D5ADF0", Offset = "0x1D5ADF0", VA = "0x7BBC55ADF0")]
		public UIHUDWereWolvesPrepareInfoController()
		{
		}

		// Token: 0x0400A21E RID: 41502
		[Token(Token = "0x400A21E")]
		[FieldOffset(Offset = "0x58")]
		private UIHUDWereWolvesPrepareInfoView m_View;

		// Token: 0x0400A21F RID: 41503
		[Token(Token = "0x400A21F")]
		[FieldOffset(Offset = "0x60")]
		private float m_EndTime;
	}
}
