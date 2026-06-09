using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020025D3 RID: 9683
	[Token(Token = "0x20025D3")]
	public class DummyTask : BaseTask
	{
		// Token: 0x0600C71F RID: 50975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C71F")]
		[Address(RVA = "0x160BD08", Offset = "0x160BD08", VA = "0x7BBBE0BD08")]
		private void Awake()
		{
		}

		// Token: 0x0600C720 RID: 50976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C720")]
		[Address(RVA = "0x160BDF4", Offset = "0x160BDF4", VA = "0x7BBBE0BDF4", Slot = "4")]
		public override void OnStart()
		{
		}

		// Token: 0x0600C721 RID: 50977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C721")]
		[Address(RVA = "0x160BE1C", Offset = "0x160BE1C", VA = "0x7BBBE0BE1C")]
		private void Update()
		{
		}

		// Token: 0x0600C722 RID: 50978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C722")]
		[Address(RVA = "0x160BEE0", Offset = "0x160BEE0", VA = "0x7BBBE0BEE0")]
		public DummyTask()
		{
		}

		// Token: 0x0400F96C RID: 63852
		[Token(Token = "0x400F96C")]
		[FieldOffset(Offset = "0x68")]
		public UIProgressBar progressBar;

		// Token: 0x0400F96D RID: 63853
		[Token(Token = "0x400F96D")]
		[FieldOffset(Offset = "0x70")]
		public UIButton completeButton;

		// Token: 0x0400F96E RID: 63854
		[Token(Token = "0x400F96E")]
		[FieldOffset(Offset = "0x78")]
		public float completeTime;

		// Token: 0x0400F96F RID: 63855
		[Token(Token = "0x400F96F")]
		[FieldOffset(Offset = "0x7C")]
		private float m_CurTime;
	}
}
