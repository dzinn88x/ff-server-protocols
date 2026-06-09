using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;

namespace GCommon
{
	// Token: 0x02000F8A RID: 3978
	[Token(Token = "0x2000F8A")]
	public class NetworkDetection : MonoBehaviour
	{
		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x060039E2 RID: 14818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006E2")]
		public static NetworkDetection Instance
		{
			[Token(Token = "0x60039E2")]
			[Address(RVA = "0x245FCFC", Offset = "0x245FCFC", VA = "0x7BBCC5FCFC")]
			get
			{
				return null;
			}
		}

		// Token: 0x060039E3 RID: 14819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039E3")]
		[Address(RVA = "0x245FE58", Offset = "0x245FE58", VA = "0x7BBCC5FE58")]
		private void Init()
		{
		}

		// Token: 0x060039E4 RID: 14820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039E4")]
		[Address(RVA = "0x245FEC4", Offset = "0x245FEC4", VA = "0x7BBCC5FEC4")]
		private void OnDestroy()
		{
		}

		// Token: 0x060039E5 RID: 14821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039E5")]
		[Address(RVA = "0x245FF30", Offset = "0x245FF30", VA = "0x7BBCC5FF30")]
		public void Clear(uint include_task = 4294967295U)
		{
		}

		// Token: 0x060039E6 RID: 14822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039E6")]
		[Address(RVA = "0x2460124", Offset = "0x2460124", VA = "0x7BBCC60124")]
		public void Ping(ETaskType type, List<string> address_list, NetworkDetection.MultiTaskComplete call_back)
		{
		}

		// Token: 0x060039E7 RID: 14823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039E7")]
		[Address(RVA = "0x2460328", Offset = "0x2460328", VA = "0x7BBCC60328")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113BB30", Offset = "0x113BB30")]
		private IEnumerator MultiPing(string address, List<NetworkDetection.PingInfo> infos, NetworkDetection.TaskInfo task_info)
		{
			return null;
		}

		// Token: 0x060039E8 RID: 14824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039E8")]
		[Address(RVA = "0x2460420", Offset = "0x2460420", VA = "0x7BBCC60420")]
		private void OnPingCompleted(string address, List<NetworkDetection.PingInfo> infos, NetworkDetection.TaskInfo task_info)
		{
		}

		// Token: 0x060039E9 RID: 14825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039E9")]
		[Address(RVA = "0x2460884", Offset = "0x2460884", VA = "0x7BBCC60884")]
		public void TraceRoute(ETaskType type, List<string> address_list, uint thread_count, NetworkDetection.MultiTaskComplete call_back)
		{
		}

		// Token: 0x060039EA RID: 14826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039EA")]
		[Address(RVA = "0x24610E0", Offset = "0x24610E0", VA = "0x7BBCC610E0")]
		private void TraceRoute(string address, int thread_count)
		{
		}

		// Token: 0x060039EB RID: 14827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039EB")]
		[Address(RVA = "0x2461318", Offset = "0x2461318", VA = "0x7BBCC61318")]
		private void OnTraceRouteTaskComplete(TracerouteResult result)
		{
		}

		// Token: 0x060039EC RID: 14828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039EC")]
		[Address(RVA = "0x246142C", Offset = "0x246142C", VA = "0x7BBCC6142C")]
		public void OnTraceRouteCompleted(string data)
		{
		}

		// Token: 0x060039ED RID: 14829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039ED")]
		[Address(RVA = "0x24617E0", Offset = "0x24617E0", VA = "0x7BBCC617E0")]
		public void CDNDownload(string url, NetworkDetection.MultiTaskComplete call_back)
		{
		}

		// Token: 0x060039EE RID: 14830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039EE")]
		[Address(RVA = "0x24618C8", Offset = "0x24618C8", VA = "0x7BBCC618C8")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113BB94", Offset = "0x113BB94")]
		private IEnumerator TestCDN(string url)
		{
			return null;
		}

		// Token: 0x060039EF RID: 14831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039EF")]
		[Address(RVA = "0x2460728", Offset = "0x2460728", VA = "0x7BBCC60728")]
		private void OnTaskComplete(NetworkDetection.TaskInfo task_info)
		{
		}

		// Token: 0x060039F0 RID: 14832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039F0")]
		[Address(RVA = "0x24619A4", Offset = "0x24619A4", VA = "0x7BBCC619A4")]
		private void Update()
		{
		}

		// Token: 0x060039F1 RID: 14833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039F1")]
		[Address(RVA = "0x2461C0C", Offset = "0x2461C0C", VA = "0x7BBCC61C0C")]
		public NetworkDetection()
		{
		}

		// Token: 0x04004B82 RID: 19330
		[Token(Token = "0x4004B82")]
		private const float PING_TIMEOUT = 3f;

		// Token: 0x04004B83 RID: 19331
		[Token(Token = "0x4004B83")]
		private const int PING_COUNT = 5;

		// Token: 0x04004B84 RID: 19332
		[Token(Token = "0x4004B84")]
		private const string ERROR_CODE_START = "ErrorCode:";

		// Token: 0x04004B85 RID: 19333
		[Token(Token = "0x4004B85")]
		[FieldOffset(Offset = "0x0")]
		private static NetworkDetection m_Instance;

		// Token: 0x04004B86 RID: 19334
		[Token(Token = "0x4004B86")]
		[FieldOffset(Offset = "0x18")]
		private float m_StartTime;

		// Token: 0x04004B87 RID: 19335
		[Token(Token = "0x4004B87")]
		[FieldOffset(Offset = "0x20")]
		private LinkedList<NetworkDetection.TaskInfo> m_PendingTaskList;

		// Token: 0x04004B88 RID: 19336
		[Token(Token = "0x4004B88")]
		[FieldOffset(Offset = "0x28")]
		private NetworkDetection.TaskInfo m_RunningTask;

		// Token: 0x02000F8B RID: 3979
		// (Invoke) Token: 0x060039F3 RID: 14835
		[Token(Token = "0x2000F8B")]
		public delegate void MultiTaskComplete(List<NetDetectionResult> results);

		// Token: 0x02000F8C RID: 3980
		[Token(Token = "0x2000F8C")]
		private struct PingInfo
		{
			// Token: 0x04004B89 RID: 19337
			[Token(Token = "0x4004B89")]
			[FieldOffset(Offset = "0x0")]
			public float PingTime;

			// Token: 0x04004B8A RID: 19338
			[Token(Token = "0x4004B8A")]
			[FieldOffset(Offset = "0x4")]
			public bool IsTimeOut;
		}

		// Token: 0x02000F8D RID: 3981
		[Token(Token = "0x2000F8D")]
		private class TaskInfo
		{
			// Token: 0x060039F6 RID: 14838 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60039F6")]
			[Address(RVA = "0x24601D0", Offset = "0x24601D0", VA = "0x7BBCC601D0")]
			public TaskInfo(List<string> target_ip_list, ETaskType type, ETaskFunction func, NetworkDetection.MultiTaskComplete complete_callback, uint thread_count = 1U)
			{
			}

			// Token: 0x060039F7 RID: 14839 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60039F7")]
			[Address(RVA = "0x246075C", Offset = "0x246075C", VA = "0x7BBCC6075C")]
			public string GetNextPingAddress()
			{
				return null;
			}

			// Token: 0x060039F8 RID: 14840 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60039F8")]
			[Address(RVA = "0x246198C", Offset = "0x246198C", VA = "0x7BBCC6198C")]
			public void InvokeComplete()
			{
			}

			// Token: 0x04004B8B RID: 19339
			[Token(Token = "0x4004B8B")]
			[FieldOffset(Offset = "0x10")]
			public List<string> TargetIPList;

			// Token: 0x04004B8C RID: 19340
			[Token(Token = "0x4004B8C")]
			[FieldOffset(Offset = "0x18")]
			public List<NetDetectionResult> Results;

			// Token: 0x04004B8D RID: 19341
			[Token(Token = "0x4004B8D")]
			[FieldOffset(Offset = "0x20")]
			public int IPCount;

			// Token: 0x04004B8E RID: 19342
			[Token(Token = "0x4004B8E")]
			[FieldOffset(Offset = "0x24")]
			public ETaskType TaskType;

			// Token: 0x04004B8F RID: 19343
			[Token(Token = "0x4004B8F")]
			[FieldOffset(Offset = "0x28")]
			public ETaskFunction TaskFunc;

			// Token: 0x04004B90 RID: 19344
			[Token(Token = "0x4004B90")]
			[FieldOffset(Offset = "0x2C")]
			public uint ThreadCount;

			// Token: 0x04004B91 RID: 19345
			[Token(Token = "0x4004B91")]
			[FieldOffset(Offset = "0x30")]
			private NetworkDetection.MultiTaskComplete call_back;
		}

		// Token: 0x02000F8E RID: 3982
		[Token(Token = "0x2000F8E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA520", Offset = "0x10EA520")]
		private sealed class <MultiPing>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060039F9 RID: 14841 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60039F9")]
			[Address(RVA = "0x24603F4", Offset = "0x24603F4", VA = "0x7BBCC603F4")]
			[DebuggerHidden]
			public <MultiPing>d__16(int <>1__state)
			{
			}

			// Token: 0x060039FA RID: 14842 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60039FA")]
			[Address(RVA = "0x2461CB4", Offset = "0x2461CB4", VA = "0x7BBCC61CB4", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060039FB RID: 14843 RVA: 0x00011F10 File Offset: 0x00010110
			[Token(Token = "0x60039FB")]
			[Address(RVA = "0x2461CB8", Offset = "0x2461CB8", VA = "0x7BBCC61CB8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170006E3 RID: 1763
			// (get) Token: 0x060039FC RID: 14844 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006E3")]
			private object Current
			{
				[Token(Token = "0x60039FC")]
				[Address(RVA = "0x2461F98", Offset = "0x2461F98", VA = "0x7BBCC61F98", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060039FD RID: 14845 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60039FD")]
			[Address(RVA = "0x2461FA0", Offset = "0x2461FA0", VA = "0x7BBCC61FA0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170006E4 RID: 1764
			// (get) Token: 0x060039FE RID: 14846 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006E4")]
			private object Current
			{
				[Token(Token = "0x60039FE")]
				[Address(RVA = "0x2462008", Offset = "0x2462008", VA = "0x7BBCC62008", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04004B92 RID: 19346
			[Token(Token = "0x4004B92")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04004B93 RID: 19347
			[Token(Token = "0x4004B93")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04004B94 RID: 19348
			[Token(Token = "0x4004B94")]
			[FieldOffset(Offset = "0x20")]
			public string address;

			// Token: 0x04004B95 RID: 19349
			[Token(Token = "0x4004B95")]
			[FieldOffset(Offset = "0x28")]
			public List<NetworkDetection.PingInfo> infos;

			// Token: 0x04004B96 RID: 19350
			[Token(Token = "0x4004B96")]
			[FieldOffset(Offset = "0x30")]
			public NetworkDetection <>4__this;

			// Token: 0x04004B97 RID: 19351
			[Token(Token = "0x4004B97")]
			[FieldOffset(Offset = "0x38")]
			public NetworkDetection.TaskInfo task_info;

			// Token: 0x04004B98 RID: 19352
			[Token(Token = "0x4004B98")]
			[FieldOffset(Offset = "0x40")]
			private Ping <ping>5__2;

			// Token: 0x04004B99 RID: 19353
			[Token(Token = "0x4004B99")]
			[FieldOffset(Offset = "0x48")]
			private float <used_time>5__3;
		}

		// Token: 0x02000F8F RID: 3983
		[Token(Token = "0x2000F8F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA530", Offset = "0x10EA530")]
		private sealed class <>c__DisplayClass21_0
		{
			// Token: 0x060039FF RID: 14847 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60039FF")]
			[Address(RVA = "0x24617D8", Offset = "0x24617D8", VA = "0x7BBCC617D8")]
			public <>c__DisplayClass21_0()
			{
			}

			// Token: 0x06003A00 RID: 14848 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A00")]
			[Address(RVA = "0x2461C7C", Offset = "0x2461C7C", VA = "0x7BBCC61C7C")]
			internal void <OnTraceRouteCompleted>b__0()
			{
			}

			// Token: 0x04004B9A RID: 19354
			[Token(Token = "0x4004B9A")]
			[FieldOffset(Offset = "0x10")]
			public TracerouteResult result;
		}

		// Token: 0x02000F90 RID: 3984
		[Token(Token = "0x2000F90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA540", Offset = "0x10EA540")]
		private sealed class <TestCDN>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06003A01 RID: 14849 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A01")]
			[Address(RVA = "0x2461960", Offset = "0x2461960", VA = "0x7BBCC61960")]
			[DebuggerHidden]
			public <TestCDN>d__23(int <>1__state)
			{
			}

			// Token: 0x06003A02 RID: 14850 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A02")]
			[Address(RVA = "0x2462010", Offset = "0x2462010", VA = "0x7BBCC62010", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06003A03 RID: 14851 RVA: 0x00011F28 File Offset: 0x00010128
			[Token(Token = "0x6003A03")]
			[Address(RVA = "0x2462014", Offset = "0x2462014", VA = "0x7BBCC62014", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170006E5 RID: 1765
			// (get) Token: 0x06003A04 RID: 14852 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006E5")]
			private object Current
			{
				[Token(Token = "0x6003A04")]
				[Address(RVA = "0x24621FC", Offset = "0x24621FC", VA = "0x7BBCC621FC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06003A05 RID: 14853 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003A05")]
			[Address(RVA = "0x2462204", Offset = "0x2462204", VA = "0x7BBCC62204", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170006E6 RID: 1766
			// (get) Token: 0x06003A06 RID: 14854 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006E6")]
			private object Current
			{
				[Token(Token = "0x6003A06")]
				[Address(RVA = "0x246226C", Offset = "0x246226C", VA = "0x7BBCC6226C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04004B9B RID: 19355
			[Token(Token = "0x4004B9B")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04004B9C RID: 19356
			[Token(Token = "0x4004B9C")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04004B9D RID: 19357
			[Token(Token = "0x4004B9D")]
			[FieldOffset(Offset = "0x20")]
			public NetworkDetection <>4__this;

			// Token: 0x04004B9E RID: 19358
			[Token(Token = "0x4004B9E")]
			[FieldOffset(Offset = "0x28")]
			public string url;

			// Token: 0x04004B9F RID: 19359
			[Token(Token = "0x4004B9F")]
			[FieldOffset(Offset = "0x30")]
			private UnityWebRequest <webRequest>5__2;
		}
	}
}
