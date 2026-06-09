using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW
{
	// Token: 0x02001E2A RID: 7722
	[Token(Token = "0x2001E2A")]
	public class UIModelConnectionReport : UIBaseModel
	{
		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x0600A8D1 RID: 43217 RVA: 0x0002DAF8 File Offset: 0x0002BCF8
		// (set) Token: 0x0600A8D2 RID: 43218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B0E")]
		public bool IsInSendingTraceRouteReport
		{
			[Token(Token = "0x600A8D1")]
			[Address(RVA = "0x233A0D4", Offset = "0x233A0D4", VA = "0x7BBCB3A0D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145ECC", Offset = "0x1145ECC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A8D2")]
			[Address(RVA = "0x233A0DC", Offset = "0x233A0DC", VA = "0x7BBCB3A0DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145EDC", Offset = "0x1145EDC")]
			private set
			{
			}
		}

		// Token: 0x0600A8D3 RID: 43219 RVA: 0x0002DB10 File Offset: 0x0002BD10
		[Token(Token = "0x600A8D3")]
		[Address(RVA = "0x233A0E8", Offset = "0x233A0E8", VA = "0x7BBCB3A0E8", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600A8D4 RID: 43220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8D4")]
		[Address(RVA = "0x233A0F0", Offset = "0x233A0F0", VA = "0x7BBCB3A0F0", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600A8D5 RID: 43221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8D5")]
		[Address(RVA = "0x233A730", Offset = "0x233A730", VA = "0x7BBCB3A730")]
		public void OnFrontEndGameLoaded()
		{
		}

		// Token: 0x0600A8D6 RID: 43222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8D6")]
		[Address(RVA = "0x233A828", Offset = "0x233A828", VA = "0x7BBCB3A828")]
		public void OnFrontEndGameDestroy()
		{
		}

		// Token: 0x0600A8D7 RID: 43223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8D7")]
		[Address(RVA = "0x233A68C", Offset = "0x233A68C", VA = "0x7BBCB3A68C")]
		public void StartIDCPing(int start_index = 0)
		{
		}

		// Token: 0x0600A8D8 RID: 43224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8D8")]
		[Address(RVA = "0x233AB68", Offset = "0x233AB68", VA = "0x7BBCB3AB68")]
		public void ConstractIDCPingResult(List<AccountIDCPingInfo> ping_list)
		{
		}

		// Token: 0x0600A8D9 RID: 43225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8D9")]
		[Address(RVA = "0x233A910", Offset = "0x233A910", VA = "0x7BBCB3A910")]
		private void PingGSNode(int index)
		{
		}

		// Token: 0x0600A8DA RID: 43226 RVA: 0x0002DB28 File Offset: 0x0002BD28
		[Token(Token = "0x600A8DA")]
		[Address(RVA = "0x233ACBC", Offset = "0x233ACBC", VA = "0x7BBCB3ACBC")]
		public static bool HasNeedCheckIP()
		{
			return default(bool);
		}

		// Token: 0x0600A8DB RID: 43227 RVA: 0x0002DB40 File Offset: 0x0002BD40
		[Token(Token = "0x600A8DB")]
		[Address(RVA = "0x233AD24", Offset = "0x233AD24", VA = "0x7BBCB3AD24")]
		public bool CheckNeedShowWhenLoginFailed()
		{
			return default(bool);
		}

		// Token: 0x0600A8DC RID: 43228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8DC")]
		[Address(RVA = "0x233AF1C", Offset = "0x233AF1C", VA = "0x7BBCB3AF1C")]
		public void OnServiceDisconnect(DisconnectedReason reason)
		{
		}

		// Token: 0x0600A8DD RID: 43229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8DD")]
		[Address(RVA = "0x233AF48", Offset = "0x233AF48", VA = "0x7BBCB3AF48")]
		public void CheckLastDisconnectReason()
		{
		}

		// Token: 0x0600A8DE RID: 43230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8DE")]
		[Address(RVA = "0x233B004", Offset = "0x233B004", VA = "0x7BBCB3B004")]
		public void CollectNetworkReportAndSend()
		{
		}

		// Token: 0x0600A8DF RID: 43231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8DF")]
		[Address(RVA = "0x233B1F8", Offset = "0x233B1F8", VA = "0x7BBCB3B1F8")]
		public static void CollectCDNDownloadReportAndSend(string url)
		{
		}

		// Token: 0x0600A8E0 RID: 43232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8E0")]
		[Address(RVA = "0x233B308", Offset = "0x233B308", VA = "0x7BBCB3B308")]
		private void OnSendedReport()
		{
		}

		// Token: 0x0600A8E1 RID: 43233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8E1")]
		[Address(RVA = "0x233B538", Offset = "0x233B538", VA = "0x7BBCB3B538")]
		private void SendPingReport(Report_Ping report_Ping)
		{
		}

		// Token: 0x0600A8E2 RID: 43234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8E2")]
		[Address(RVA = "0x233B6BC", Offset = "0x233B6BC", VA = "0x7BBCB3B6BC")]
		private void SendTraceReport(Report_TraceRoute report_TraceRoute)
		{
		}

		// Token: 0x0600A8E3 RID: 43235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8E3")]
		[Address(RVA = "0x233B848", Offset = "0x233B848", VA = "0x7BBCB3B848")]
		private static void SendCDNTestReport(Report_CDNDownload report)
		{
		}

		// Token: 0x0600A8E4 RID: 43236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8E4")]
		[Address(RVA = "0x233B9C0", Offset = "0x233B9C0", VA = "0x7BBCB3B9C0")]
		public UIModelConnectionReport()
		{
		}

		// Token: 0x0600A8E5 RID: 43237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8E5")]
		[Address(RVA = "0x233BA80", Offset = "0x233BA80", VA = "0x7BBCB3BA80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145EEC", Offset = "0x1145EEC")]
		private void <Login>b__17_0(List<NetDetectionResult> ping_results)
		{
		}

		// Token: 0x0600A8E6 RID: 43238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8E6")]
		[Address(RVA = "0x233BF0C", Offset = "0x233BF0C", VA = "0x7BBCB3BF0C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145EFC", Offset = "0x1145EFC")]
		private void <CheckNeedShowWhenLoginFailed>b__24_0()
		{
		}

		// Token: 0x0400AE2D RID: 44589
		[Token(Token = "0x400AE2D")]
		[FieldOffset(Offset = "0x0")]
		public static string[] CHECK_IP_LIST;

		// Token: 0x0400AE2E RID: 44590
		[Token(Token = "0x400AE2E")]
		[FieldOffset(Offset = "0x18")]
		public bool IsRunningCollectionTraceReport;

		// Token: 0x0400AE2F RID: 44591
		[Token(Token = "0x400AE2F")]
		[FieldOffset(Offset = "0x1C")]
		private uint m_LoginNetworkErrCount;

		// Token: 0x0400AE30 RID: 44592
		[Token(Token = "0x400AE30")]
		[FieldOffset(Offset = "0x20")]
		private uint m_ClearCountDelayCallID;

		// Token: 0x0400AE31 RID: 44593
		[Token(Token = "0x400AE31")]
		[FieldOffset(Offset = "0x24")]
		private int m_LastDisconnectReason;

		// Token: 0x0400AE32 RID: 44594
		[Token(Token = "0x400AE32")]
		public const uint PropID_TraceRouteReportSendingFlagUpdate = 2U;

		// Token: 0x0400AE33 RID: 44595
		[Token(Token = "0x400AE33")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FEFC", Offset = "0x112FEFC")]
		private bool <IsInSendingTraceRouteReport>k__BackingField;

		// Token: 0x0400AE34 RID: 44596
		[Token(Token = "0x400AE34")]
		[FieldOffset(Offset = "0x30")]
		private List<PingAddrDesc> m_PingServerIPList;

		// Token: 0x0400AE35 RID: 44597
		[Token(Token = "0x400AE35")]
		[FieldOffset(Offset = "0x38")]
		private List<GSNodeInfo> m_GSNodeList;

		// Token: 0x0400AE36 RID: 44598
		[Token(Token = "0x400AE36")]
		[FieldOffset(Offset = "0x40")]
		private int m_NextPingIndex;

		// Token: 0x0400AE37 RID: 44599
		[Token(Token = "0x400AE37")]
		[FieldOffset(Offset = "0x44")]
		private UIModelConnectionReport.EPingNodeState m_PingNodeState;

		// Token: 0x02001E2B RID: 7723
		[Token(Token = "0x2001E2B")]
		private enum EPingNodeState
		{
			// Token: 0x0400AE39 RID: 44601
			[Token(Token = "0x400AE39")]
			Waiting,
			// Token: 0x0400AE3A RID: 44602
			[Token(Token = "0x400AE3A")]
			Running,
			// Token: 0x0400AE3B RID: 44603
			[Token(Token = "0x400AE3B")]
			Paused
		}

		// Token: 0x02001E2C RID: 7724
		// (Invoke) Token: 0x0600A8E8 RID: 43240
		[Token(Token = "0x2001E2C")]
		private delegate void OnCollectComplete();

		// Token: 0x02001E2D RID: 7725
		[Token(Token = "0x2001E2D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC484", Offset = "0x10FC484")]
		private sealed class <>c__DisplayClass17_0
		{
			// Token: 0x0600A8EB RID: 43243 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A8EB")]
			[Address(RVA = "0x233BF04", Offset = "0x233BF04", VA = "0x7BBCB3BF04")]
			public <>c__DisplayClass17_0()
			{
			}

			// Token: 0x0600A8EC RID: 43244 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A8EC")]
			[Address(RVA = "0x233C2E0", Offset = "0x233C2E0", VA = "0x7BBCB3C2E0")]
			internal void <Login>b__1(List<NetDetectionResult> trace_results)
			{
			}

			// Token: 0x0400AE3C RID: 44604
			[Token(Token = "0x400AE3C")]
			[FieldOffset(Offset = "0x10")]
			public Report_Ping report_ping;

			// Token: 0x0400AE3D RID: 44605
			[Token(Token = "0x400AE3D")]
			[FieldOffset(Offset = "0x18")]
			public UIModelConnectionReport <>4__this;
		}

		// Token: 0x02001E2E RID: 7726
		[Token(Token = "0x2001E2E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC494", Offset = "0x10FC494")]
		private sealed class <>c__DisplayClass22_0
		{
			// Token: 0x0600A8ED RID: 43245 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A8ED")]
			[Address(RVA = "0x233ACB4", Offset = "0x233ACB4", VA = "0x7BBCB3ACB4")]
			public <>c__DisplayClass22_0()
			{
			}

			// Token: 0x0600A8EE RID: 43246 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A8EE")]
			[Address(RVA = "0x233C520", Offset = "0x233C520", VA = "0x7BBCB3C520")]
			internal void <PingGSNode>b__0(List<NetDetectionResult> result)
			{
			}

			// Token: 0x0400AE3E RID: 44606
			[Token(Token = "0x400AE3E")]
			[FieldOffset(Offset = "0x10")]
			public UIModelConnectionReport <>4__this;

			// Token: 0x0400AE3F RID: 44607
			[Token(Token = "0x400AE3F")]
			[FieldOffset(Offset = "0x18")]
			public int index;
		}

		// Token: 0x02001E2F RID: 7727
		[Token(Token = "0x2001E2F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC4A4", Offset = "0x10FC4A4")]
		private sealed class <>c__DisplayClass27_0
		{
			// Token: 0x0600A8EF RID: 43247 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A8EF")]
			[Address(RVA = "0x233B1F0", Offset = "0x233B1F0", VA = "0x7BBCB3B1F0")]
			public <>c__DisplayClass27_0()
			{
			}

			// Token: 0x0600A8F0 RID: 43248 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A8F0")]
			[Address(RVA = "0x233C6BC", Offset = "0x233C6BC", VA = "0x7BBCB3C6BC")]
			internal void <CollectNetworkReportAndSend>b__0(List<NetDetectionResult> ping_results)
			{
			}

			// Token: 0x0400AE40 RID: 44608
			[Token(Token = "0x400AE40")]
			[FieldOffset(Offset = "0x10")]
			public List<string> ip_list;

			// Token: 0x0400AE41 RID: 44609
			[Token(Token = "0x400AE41")]
			[FieldOffset(Offset = "0x18")]
			public UIModelConnectionReport <>4__this;
		}

		// Token: 0x02001E30 RID: 7728
		[Token(Token = "0x2001E30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC4B4", Offset = "0x10FC4B4")]
		private sealed class <>c__DisplayClass27_1
		{
			// Token: 0x0600A8F1 RID: 43249 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A8F1")]
			[Address(RVA = "0x233C9D0", Offset = "0x233C9D0", VA = "0x7BBCB3C9D0")]
			public <>c__DisplayClass27_1()
			{
			}

			// Token: 0x0600A8F2 RID: 43250 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A8F2")]
			[Address(RVA = "0x233C9D8", Offset = "0x233C9D8", VA = "0x7BBCB3C9D8")]
			internal void <CollectNetworkReportAndSend>b__1(List<NetDetectionResult> trace_results)
			{
			}

			// Token: 0x0400AE42 RID: 44610
			[Token(Token = "0x400AE42")]
			[FieldOffset(Offset = "0x10")]
			public Report_TraceRoute report_TraceRoute;

			// Token: 0x0400AE43 RID: 44611
			[Token(Token = "0x400AE43")]
			[FieldOffset(Offset = "0x18")]
			public UIModelConnectionReport.<>c__DisplayClass27_0 CS$<>8__locals1;
		}

		// Token: 0x02001E31 RID: 7729
		[Token(Token = "0x2001E31")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC4C4", Offset = "0x10FC4C4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600A8F4 RID: 43252 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A8F4")]
			[Address(RVA = "0x233BF78", Offset = "0x233BF78", VA = "0x7BBCB3BF78")]
			public <>c()
			{
			}

			// Token: 0x0600A8F5 RID: 43253 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A8F5")]
			[Address(RVA = "0x233BF80", Offset = "0x233BF80", VA = "0x7BBCB3BF80")]
			internal void <CollectCDNDownloadReportAndSend>b__28_0(List<NetDetectionResult> results)
			{
			}

			// Token: 0x0400AE44 RID: 44612
			[Token(Token = "0x400AE44")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelConnectionReport.<>c <>9;

			// Token: 0x0400AE45 RID: 44613
			[Token(Token = "0x400AE45")]
			[FieldOffset(Offset = "0x8")]
			public static NetworkDetection.MultiTaskComplete <>9__28_0;
		}
	}
}
