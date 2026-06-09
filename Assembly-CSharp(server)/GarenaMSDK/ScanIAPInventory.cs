using System;
using Il2CppDummyDll;

namespace GarenaMSDK
{
	// Token: 0x02002BEF RID: 11247
	[Token(Token = "0x2002BEF")]
	internal class ScanIAPInventory : SDKIAPTaskInstance
	{
		// Token: 0x0600F8C0 RID: 63680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8C0")]
		[Address(RVA = "0x27398DC", Offset = "0x27398DC", VA = "0x7BBCF398DC")]
		public ScanIAPInventory(SDKIAPTaskInfo info)
		{
		}

		// Token: 0x17001218 RID: 4632
		// (get) Token: 0x0600F8C1 RID: 63681 RVA: 0x00047A48 File Offset: 0x00045C48
		[Token(Token = "0x17001218")]
		public override SDKIAPTask Task
		{
			[Token(Token = "0x600F8C1")]
			[Address(RVA = "0x274150C", Offset = "0x274150C", VA = "0x7BBCF4150C", Slot = "4")]
			get
			{
				return SDKIAPTask.None;
			}
		}

		// Token: 0x0600F8C2 RID: 63682 RVA: 0x00047A60 File Offset: 0x00045C60
		[Token(Token = "0x600F8C2")]
		[Address(RVA = "0x2741514", Offset = "0x2741514", VA = "0x7BBCF41514", Slot = "10")]
		public override bool IsGoodToGo()
		{
			return default(bool);
		}

		// Token: 0x0600F8C3 RID: 63683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8C3")]
		[Address(RVA = "0x2741574", Offset = "0x2741574", VA = "0x7BBCF41574", Slot = "13")]
		protected override void Start()
		{
		}

		// Token: 0x0600F8C4 RID: 63684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8C4")]
		[Address(RVA = "0x2741664", Offset = "0x2741664", VA = "0x7BBCF41664")]
		private void OnScanIAPInventoryResult(SDKIAP.ScanIAPInventoryResult[] results)
		{
		}

		// Token: 0x0600F8C5 RID: 63685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8C5")]
		[Address(RVA = "0x2741678", Offset = "0x2741678", VA = "0x7BBCF41678", Slot = "14")]
		protected override void Succeed()
		{
		}

		// Token: 0x0600F8C6 RID: 63686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8C6")]
		[Address(RVA = "0x2741720", Offset = "0x2741720", VA = "0x7BBCF41720", Slot = "16")]
		protected override void Destroy()
		{
		}

		// Token: 0x0600F8C7 RID: 63687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F8C7")]
		[Address(RVA = "0x2741788", Offset = "0x2741788", VA = "0x7BBCF41788", Slot = "9")]
		internal override string IdentifySelf()
		{
			return null;
		}

		// Token: 0x0600F8C8 RID: 63688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8C8")]
		[Address(RVA = "0x27417F8", Offset = "0x27417F8", VA = "0x7BBCF417F8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114BC28", Offset = "0x114BC28")]
		private void <Succeed>b__8_0(ScanIAPInventory i)
		{
		}

		// Token: 0x04011CA6 RID: 72870
		[Token(Token = "0x4011CA6")]
		[FieldOffset(Offset = "0x28")]
		private SDKIAP.ScanIAPInventoryResult[] _results;

		// Token: 0x04011CA7 RID: 72871
		[Token(Token = "0x4011CA7")]
		[FieldOffset(Offset = "0x30")]
		public Action<SDKIAPTaskInfo, SDKIAP.ScanIAPInventoryResult[]> OnScanned;
	}
}
