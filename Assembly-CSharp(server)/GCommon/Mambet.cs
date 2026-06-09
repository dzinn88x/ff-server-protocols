using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GCommon
{
	// Token: 0x02000F29 RID: 3881
	[Token(Token = "0x2000F29")]
	public static class Mambet
	{
		// Token: 0x06003779 RID: 14201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003779")]
		[Address(RVA = "0x2127D28", Offset = "0x2127D28", VA = "0x7BBC927D28")]
		public static void StartVoiceDataSender(bool debug_voice)
		{
		}

		// Token: 0x0600377A RID: 14202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600377A")]
		[Address(RVA = "0x2127EA8", Offset = "0x2127EA8", VA = "0x7BBC927EA8")]
		public static void StopVoiceDataSender()
		{
		}

		// Token: 0x0600377B RID: 14203 RVA: 0x00011388 File Offset: 0x0000F588
		[Token(Token = "0x600377B")]
		[Address(RVA = "0x2127F94", Offset = "0x2127F94", VA = "0x7BBC927F94")]
		public static bool IsVoiceDataSenderRunning()
		{
			return default(bool);
		}

		// Token: 0x0600377C RID: 14204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600377C")]
		[Address(RVA = "0x2127FFC", Offset = "0x2127FFC", VA = "0x7BBC927FFC")]
		public static void RequestMic()
		{
		}

		// Token: 0x0600377D RID: 14205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600377D")]
		[Address(RVA = "0x2128080", Offset = "0x2128080", VA = "0x7BBC928080")]
		public static void ReleaseMic()
		{
		}

		// Token: 0x0600377E RID: 14206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600377E")]
		[Address(RVA = "0x2128104", Offset = "0x2128104", VA = "0x7BBC928104")]
		public static string UnityAudioBufferStatus()
		{
			return null;
		}

		// Token: 0x0600377F RID: 14207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600377F")]
		[Address(RVA = "0x2128248", Offset = "0x2128248", VA = "0x7BBC928248")]
		public static string ExternalAudioBufferStatus()
		{
			return null;
		}

		// Token: 0x06003780 RID: 14208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003780")]
		[Address(RVA = "0x212838C", Offset = "0x212838C", VA = "0x7BBC92838C")]
		private static void Log(string log)
		{
		}

		// Token: 0x06003781 RID: 14209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003781")]
		[Address(RVA = "0x212844C", Offset = "0x212844C", VA = "0x7BBC92844C")]
		private static void LogVerbose(string log)
		{
		}

		// Token: 0x06003782 RID: 14210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003782")]
		[Address(RVA = "0x212850C", Offset = "0x212850C", VA = "0x7BBC92850C")]
		public static void Init(int game_id, bool debug_mode)
		{
		}

		// Token: 0x06003783 RID: 14211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003783")]
		[Address(RVA = "0x21288E4", Offset = "0x21288E4", VA = "0x7BBC9288E4")]
		public static void SetAccountID(string accountID)
		{
		}

		// Token: 0x06003784 RID: 14212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003784")]
		[Address(RVA = "0x21289CC", Offset = "0x21289CC", VA = "0x7BBC9289CC")]
		public static void PushEvent(string type, string data)
		{
		}

		// Token: 0x06003785 RID: 14213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003785")]
		[Address(RVA = "0x2128B00", Offset = "0x2128B00", VA = "0x7BBC928B00")]
		public static void StartCaptureUnityAudio()
		{
		}

		// Token: 0x06003786 RID: 14214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003786")]
		[Address(RVA = "0x2129080", Offset = "0x2129080", VA = "0x7BBC929080")]
		public static void StopCaptureUnityAudio()
		{
		}

		// Token: 0x06003787 RID: 14215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003787")]
		[Address(RVA = "0x2129350", Offset = "0x2129350", VA = "0x7BBC929350")]
		public static void AfterSwitchScene()
		{
		}

		// Token: 0x06003788 RID: 14216 RVA: 0x000113A0 File Offset: 0x0000F5A0
		[Token(Token = "0x6003788")]
		[Address(RVA = "0x2129354", Offset = "0x2129354", VA = "0x7BBC929354")]
		public static bool IsCapturingUnityAudio()
		{
			return default(bool);
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06003789 RID: 14217 RVA: 0x000113B8 File Offset: 0x0000F5B8
		// (set) Token: 0x0600378A RID: 14218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006C6")]
		public static int UnityAudioCaptureCalls
		{
			[Token(Token = "0x6003789")]
			[Address(RVA = "0x21293F8", Offset = "0x21293F8", VA = "0x7BBC9293F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B84C", Offset = "0x113B84C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600378A")]
			[Address(RVA = "0x2128D98", Offset = "0x2128D98", VA = "0x7BBC928D98")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B85C", Offset = "0x113B85C")]
			private set
			{
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x0600378B RID: 14219 RVA: 0x000113D0 File Offset: 0x0000F5D0
		// (set) Token: 0x0600378C RID: 14220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006C7")]
		public static int UnityAudioStreamNextID
		{
			[Token(Token = "0x600378B")]
			[Address(RVA = "0x2129460", Offset = "0x2129460", VA = "0x7BBC929460")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B86C", Offset = "0x113B86C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600378C")]
			[Address(RVA = "0x2129014", Offset = "0x2129014", VA = "0x7BBC929014")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B87C", Offset = "0x113B87C")]
			private set
			{
			}
		}

		// Token: 0x0600378D RID: 14221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600378D")]
		[Address(RVA = "0x21294C8", Offset = "0x21294C8", VA = "0x7BBC9294C8")]
		private static void OnUnityAudioCaptured(float[] sample, int channels, int sampleRate)
		{
		}

		// Token: 0x0600378E RID: 14222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600378E")]
		[Address(RVA = "0x2129798", Offset = "0x2129798", VA = "0x7BBC929798")]
		private static void StreamUnityAudio()
		{
		}

		// Token: 0x0600378F RID: 14223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600378F")]
		[Address(RVA = "0x2129CB0", Offset = "0x2129CB0", VA = "0x7BBC929CB0")]
		public static void StartCaptureExternalAudio()
		{
		}

		// Token: 0x06003790 RID: 14224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003790")]
		[Address(RVA = "0x2129FF8", Offset = "0x2129FF8", VA = "0x7BBC929FF8")]
		public static void StopCaptureExternalAudio()
		{
		}

		// Token: 0x06003791 RID: 14225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003791")]
		[Address(RVA = "0x212A1F0", Offset = "0x212A1F0", VA = "0x7BBC92A1F0")]
		private static void StreamExternalAudio()
		{
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06003792 RID: 14226 RVA: 0x000113E8 File Offset: 0x0000F5E8
		// (set) Token: 0x06003793 RID: 14227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006C8")]
		public static int ExternalAudioCaptureCalls
		{
			[Token(Token = "0x6003792")]
			[Address(RVA = "0x212A7C8", Offset = "0x212A7C8", VA = "0x7BBC92A7C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B88C", Offset = "0x113B88C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003793")]
			[Address(RVA = "0x2129F20", Offset = "0x2129F20", VA = "0x7BBC929F20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B89C", Offset = "0x113B89C")]
			private set
			{
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06003794 RID: 14228 RVA: 0x00011400 File Offset: 0x0000F600
		// (set) Token: 0x06003795 RID: 14229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006C9")]
		public static int ExternalAudioStreamNextID
		{
			[Token(Token = "0x6003794")]
			[Address(RVA = "0x212A46C", Offset = "0x212A46C", VA = "0x7BBC92A46C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B8AC", Offset = "0x113B8AC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003795")]
			[Address(RVA = "0x2129F8C", Offset = "0x2129F8C", VA = "0x7BBC929F8C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B8BC", Offset = "0x113B8BC")]
			private set
			{
			}
		}

		// Token: 0x06003796 RID: 14230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003796")]
		[Address(RVA = "0x212A830", Offset = "0x212A830", VA = "0x7BBC92A830")]
		public static void OnExternalAudioCaptured(byte[] sample, int channels, int sampleRate, Mambet.ExternalAudioChannel channel, int bytesPerSample)
		{
		}

		// Token: 0x04004A06 RID: 18950
		[Token(Token = "0x4004A06")]
		[FieldOffset(Offset = "0x0")]
		private static bool _VoiceDataSending;

		// Token: 0x04004A07 RID: 18951
		[Token(Token = "0x4004A07")]
		[FieldOffset(Offset = "0x8")]
		private static Mambet.AudioBuffer<float> _UnityAudioBuffers;

		// Token: 0x04004A08 RID: 18952
		[Token(Token = "0x4004A08")]
		[FieldOffset(Offset = "0x10")]
		private static Mambet.AudioBuffer<byte> _ExternalAudioBuffers;

		// Token: 0x04004A09 RID: 18953
		[Token(Token = "0x4004A09")]
		[FieldOffset(Offset = "0x18")]
		public static Action<bool> OnConnectChanged;

		// Token: 0x04004A0A RID: 18954
		[Token(Token = "0x4004A0A")]
		[FieldOffset(Offset = "0x20")]
		public static Action<bool> OnMicFocusChanged;

		// Token: 0x04004A0B RID: 18955
		[Token(Token = "0x4004A0B")]
		[FieldOffset(Offset = "0x28")]
		public static Action<int> OnUnityAudioCaptureCall;

		// Token: 0x04004A0C RID: 18956
		[Token(Token = "0x4004A0C")]
		[FieldOffset(Offset = "0x30")]
		public static Action<string> OnLog;

		// Token: 0x04004A0D RID: 18957
		[Token(Token = "0x4004A0D")]
		[FieldOffset(Offset = "0x38")]
		public static Action<string> OnLogVerbose;

		// Token: 0x04004A0E RID: 18958
		[Token(Token = "0x4004A0E")]
		[FieldOffset(Offset = "0x40")]
		private static Mambet.MambetHandler _MambetHandler;

		// Token: 0x04004A0F RID: 18959
		[Token(Token = "0x4004A0F")]
		private const string MAMBET_HANDLER_GAMEOBJECT_NAME = "MambetHandler";

		// Token: 0x04004A10 RID: 18960
		[Token(Token = "0x4004A10")]
		[FieldOffset(Offset = "0x48")]
		private static Thread _UnityAudioStreamThread;

		// Token: 0x04004A11 RID: 18961
		[Token(Token = "0x4004A11")]
		[FieldOffset(Offset = "0x50")]
		public static float UnityAudioCaptureOverhead_MS;

		// Token: 0x04004A12 RID: 18962
		[Token(Token = "0x4004A12")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112E8B4", Offset = "0x112E8B4")]
		private static int <UnityAudioCaptureCalls>k__BackingField;

		// Token: 0x04004A13 RID: 18963
		[Token(Token = "0x4004A13")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112E8C4", Offset = "0x112E8C4")]
		private static int <UnityAudioStreamNextID>k__BackingField;

		// Token: 0x04004A14 RID: 18964
		[Token(Token = "0x4004A14")]
		[FieldOffset(Offset = "0x60")]
		private static Thread _ExternalAudioStreamThread;

		// Token: 0x04004A15 RID: 18965
		[Token(Token = "0x4004A15")]
		[FieldOffset(Offset = "0x68")]
		private static bool _ExternalAudioCapturing;

		// Token: 0x04004A16 RID: 18966
		[Token(Token = "0x4004A16")]
		[FieldOffset(Offset = "0x6C")]
		public static float ExternalAudioCaptureOverhead_MS;

		// Token: 0x04004A17 RID: 18967
		[Token(Token = "0x4004A17")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112E8D4", Offset = "0x112E8D4")]
		private static int <ExternalAudioCaptureCalls>k__BackingField;

		// Token: 0x04004A18 RID: 18968
		[Token(Token = "0x4004A18")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112E8E4", Offset = "0x112E8E4")]
		private static int <ExternalAudioStreamNextID>k__BackingField;

		// Token: 0x02000F2A RID: 3882
		[Token(Token = "0x2000F2A")]
		private class AudioBufferUnit<T>
		{
			// Token: 0x06003798 RID: 14232 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003798")]
			public AudioBufferUnit()
			{
			}

			// Token: 0x04004A19 RID: 18969
			[Token(Token = "0x4004A19")]
			[FieldOffset(Offset = "0x0")]
			public int ID;

			// Token: 0x04004A1A RID: 18970
			[Token(Token = "0x4004A1A")]
			[FieldOffset(Offset = "0x0")]
			public T[] Data;

			// Token: 0x04004A1B RID: 18971
			[Token(Token = "0x4004A1B")]
			[FieldOffset(Offset = "0x0")]
			public int BytesPerSample;

			// Token: 0x04004A1C RID: 18972
			[Token(Token = "0x4004A1C")]
			[FieldOffset(Offset = "0x0")]
			public int Channels;

			// Token: 0x04004A1D RID: 18973
			[Token(Token = "0x4004A1D")]
			[FieldOffset(Offset = "0x0")]
			public int SampleRate;

			// Token: 0x04004A1E RID: 18974
			[Token(Token = "0x4004A1E")]
			[FieldOffset(Offset = "0x0")]
			public int Channel;
		}

		// Token: 0x02000F2B RID: 3883
		[Token(Token = "0x2000F2B")]
		private class AudioBufferGroup<T>
		{
			// Token: 0x06003799 RID: 14233 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003799")]
			public Mambet.AudioBufferUnit<T> Retrieve(int id)
			{
				return null;
			}

			// Token: 0x0600379A RID: 14234 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600379A")]
			public Mambet.AudioBufferUnit<T> Occupy(int id, T[] data)
			{
				return null;
			}

			// Token: 0x0600379B RID: 14235 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600379B")]
			public void Release(int id)
			{
			}

			// Token: 0x0600379C RID: 14236 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600379C")]
			public void Clear()
			{
			}

			// Token: 0x0600379D RID: 14237 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600379D")]
			public string Status()
			{
				return null;
			}

			// Token: 0x0600379E RID: 14238 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600379E")]
			public AudioBufferGroup()
			{
			}

			// Token: 0x04004A1F RID: 18975
			[Token(Token = "0x4004A1F")]
			[FieldOffset(Offset = "0x0")]
			private Dictionary<int, Mambet.AudioBufferUnit<T>> _Busy;

			// Token: 0x04004A20 RID: 18976
			[Token(Token = "0x4004A20")]
			[FieldOffset(Offset = "0x0")]
			private Queue<Mambet.AudioBufferUnit<T>> _Idle;
		}

		// Token: 0x02000F2C RID: 3884
		[Token(Token = "0x2000F2C")]
		private class AudioBuffer<T>
		{
			// Token: 0x0600379F RID: 14239 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600379F")]
			public Mambet.AudioBufferUnit<T> Retrieve(int id)
			{
				return null;
			}

			// Token: 0x060037A0 RID: 14240 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60037A0")]
			public Mambet.AudioBufferUnit<T> Occupy(int id, T[] data)
			{
				return null;
			}

			// Token: 0x060037A1 RID: 14241 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60037A1")]
			public void Release(int id, int length)
			{
			}

			// Token: 0x060037A2 RID: 14242 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60037A2")]
			public void Clear()
			{
			}

			// Token: 0x060037A3 RID: 14243 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60037A3")]
			public string Status()
			{
				return null;
			}

			// Token: 0x060037A4 RID: 14244 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60037A4")]
			public AudioBuffer()
			{
			}

			// Token: 0x04004A21 RID: 18977
			[Token(Token = "0x4004A21")]
			[FieldOffset(Offset = "0x0")]
			private Dictionary<int, Mambet.AudioBufferGroup<T>> _Buffers;
		}

		// Token: 0x02000F2D RID: 3885
		[Token(Token = "0x2000F2D")]
		private class UnityAudioCapturerWatcher : MonoBehaviour
		{
			// Token: 0x060037A5 RID: 14245 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60037A5")]
			[Address(RVA = "0x2128E04", Offset = "0x2128E04", VA = "0x7BBC928E04")]
			public static void Create()
			{
			}

			// Token: 0x060037A6 RID: 14246 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60037A6")]
			[Address(RVA = "0x212BD10", Offset = "0x212BD10", VA = "0x7BBC92BD10")]
			public void OnDestroy()
			{
			}

			// Token: 0x060037A7 RID: 14247 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60037A7")]
			[Address(RVA = "0x212BDB8", Offset = "0x212BDB8", VA = "0x7BBC92BDB8")]
			private static void OnActiveSceneChanged(Scene prev, Scene next)
			{
			}

			// Token: 0x060037A8 RID: 14248 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60037A8")]
			[Address(RVA = "0x212BBB4", Offset = "0x212BBB4", VA = "0x7BBC92BBB4")]
			public static void OnUnityAudioCapturerDestroy()
			{
			}

			// Token: 0x060037A9 RID: 14249 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60037A9")]
			[Address(RVA = "0x212BEA4", Offset = "0x212BEA4", VA = "0x7BBC92BEA4")]
			private static void EnsureCapture()
			{
			}

			// Token: 0x060037AA RID: 14250 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60037AA")]
			[Address(RVA = "0x212C024", Offset = "0x212C024", VA = "0x7BBC92C024")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113B8CC", Offset = "0x113B8CC")]
			private static IEnumerator _EnsureCapture()
			{
				return null;
			}

			// Token: 0x060037AB RID: 14251 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60037AB")]
			[Address(RVA = "0x212C0B0", Offset = "0x212C0B0", VA = "0x7BBC92C0B0")]
			public UnityAudioCapturerWatcher()
			{
			}

			// Token: 0x04004A22 RID: 18978
			[Token(Token = "0x4004A22")]
			[FieldOffset(Offset = "0x0")]
			private static Mambet.UnityAudioCapturerWatcher _I;

			// Token: 0x04004A23 RID: 18979
			[Token(Token = "0x4004A23")]
			[FieldOffset(Offset = "0x8")]
			private static bool _ActiveSceneChanged;

			// Token: 0x04004A24 RID: 18980
			[Token(Token = "0x4004A24")]
			[FieldOffset(Offset = "0x9")]
			private static bool _UnityAudioCapturerDestroyed;

			// Token: 0x02000F2E RID: 3886
			[Token(Token = "0x2000F2E")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA430", Offset = "0x10EA430")]
			private sealed class <_EnsureCapture>d__8 : IEnumerator<object>, IEnumerator, IDisposable
			{
				// Token: 0x060037AD RID: 14253 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60037AD")]
				[Address(RVA = "0x212C084", Offset = "0x212C084", VA = "0x7BBC92C084")]
				[DebuggerHidden]
				public <_EnsureCapture>d__8(int <>1__state)
				{
				}

				// Token: 0x060037AE RID: 14254 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60037AE")]
				[Address(RVA = "0x212C0BC", Offset = "0x212C0BC", VA = "0x7BBC92C0BC", Slot = "5")]
				[DebuggerHidden]
				private void Dispose()
				{
				}

				// Token: 0x060037AF RID: 14255 RVA: 0x00011418 File Offset: 0x0000F618
				[Token(Token = "0x60037AF")]
				[Address(RVA = "0x212C0C0", Offset = "0x212C0C0", VA = "0x7BBC92C0C0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x170006CA RID: 1738
				// (get) Token: 0x060037B0 RID: 14256 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x170006CA")]
				private object Current
				{
					[Token(Token = "0x60037B0")]
					[Address(RVA = "0x212C198", Offset = "0x212C198", VA = "0x7BBC92C198", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x060037B1 RID: 14257 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60037B1")]
				[Address(RVA = "0x212C1A0", Offset = "0x212C1A0", VA = "0x7BBC92C1A0", Slot = "8")]
				[DebuggerHidden]
				private void Reset()
				{
				}

				// Token: 0x170006CB RID: 1739
				// (get) Token: 0x060037B2 RID: 14258 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x170006CB")]
				private object Current
				{
					[Token(Token = "0x60037B2")]
					[Address(RVA = "0x212C208", Offset = "0x212C208", VA = "0x7BBC92C208", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x04004A25 RID: 18981
				[Token(Token = "0x4004A25")]
				[FieldOffset(Offset = "0x10")]
				private int <>1__state;

				// Token: 0x04004A26 RID: 18982
				[Token(Token = "0x4004A26")]
				[FieldOffset(Offset = "0x18")]
				private object <>2__current;
			}
		}

		// Token: 0x02000F2F RID: 3887
		[Token(Token = "0x2000F2F")]
		public class UnityAudioCapturer : MonoBehaviour
		{
			// Token: 0x060037B3 RID: 14259 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60037B3")]
			[Address(RVA = "0x2128F90", Offset = "0x2128F90", VA = "0x7BBC928F90")]
			public static void Create()
			{
			}

			// Token: 0x060037B4 RID: 14260 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60037B4")]
			[Address(RVA = "0x212B820", Offset = "0x212B820", VA = "0x7BBC92B820")]
			public static void EnsureCapture()
			{
			}

			// Token: 0x060037B5 RID: 14261 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60037B5")]
			[Address(RVA = "0x2129250", Offset = "0x2129250", VA = "0x7BBC929250")]
			public static void Stop()
			{
			}

			// Token: 0x060037B6 RID: 14262 RVA: 0x00011430 File Offset: 0x0000F630
			[Token(Token = "0x60037B6")]
			[Address(RVA = "0x2129C60", Offset = "0x2129C60", VA = "0x7BBC929C60")]
			public static bool ShouldBeRunning()
			{
				return default(bool);
			}

			// Token: 0x060037B7 RID: 14263 RVA: 0x00011448 File Offset: 0x0000F648
			[Token(Token = "0x60037B7")]
			[Address(RVA = "0x2129358", Offset = "0x2129358", VA = "0x7BBC929358")]
			public static bool IsRunning()
			{
				return default(bool);
			}

			// Token: 0x060037B8 RID: 14264 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60037B8")]
			[Address(RVA = "0x212BA50", Offset = "0x212BA50", VA = "0x7BBC92BA50")]
			private void Update()
			{
			}

			// Token: 0x060037B9 RID: 14265 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60037B9")]
			[Address(RVA = "0x212BA78", Offset = "0x212BA78", VA = "0x7BBC92BA78")]
			public void OnAudioFilterRead(float[] data, int channels)
			{
			}

			// Token: 0x060037BA RID: 14266 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60037BA")]
			[Address(RVA = "0x212BB14", Offset = "0x212BB14", VA = "0x7BBC92BB14")]
			public void OnDestroy()
			{
			}

			// Token: 0x060037BB RID: 14267 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60037BB")]
			[Address(RVA = "0x212BC50", Offset = "0x212BC50", VA = "0x7BBC92BC50")]
			public void OnApplicationPause(bool paused)
			{
			}

			// Token: 0x060037BC RID: 14268 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60037BC")]
			[Address(RVA = "0x212BD08", Offset = "0x212BD08", VA = "0x7BBC92BD08")]
			public UnityAudioCapturer()
			{
			}

			// Token: 0x04004A27 RID: 18983
			[Token(Token = "0x4004A27")]
			[FieldOffset(Offset = "0x0")]
			private static Mambet.UnityAudioCapturer _I;

			// Token: 0x04004A28 RID: 18984
			[Token(Token = "0x4004A28")]
			[FieldOffset(Offset = "0x8")]
			public static Action<float[], int, int> OnCaptured;

			// Token: 0x04004A29 RID: 18985
			[Token(Token = "0x4004A29")]
			[FieldOffset(Offset = "0x18")]
			private int _OutputSampleRate;

			// Token: 0x04004A2A RID: 18986
			[Token(Token = "0x4004A2A")]
			[FieldOffset(Offset = "0x10")]
			private static bool _Running;
		}

		// Token: 0x02000F30 RID: 3888
		[Token(Token = "0x2000F30")]
		private class MambetHandler : MonoBehaviour
		{
			// Token: 0x060037BD RID: 14269 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60037BD")]
			[Address(RVA = "0x212AB74", Offset = "0x212AB74", VA = "0x7BBC92AB74")]
			private void OnApplicationPause(bool paused)
			{
			}

			// Token: 0x060037BE RID: 14270 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60037BE")]
			[Address(RVA = "0x212AC28", Offset = "0x212AC28", VA = "0x7BBC92AC28")]
			private void OnApplicationQuit()
			{
			}

			// Token: 0x060037BF RID: 14271 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60037BF")]
			[Address(RVA = "0x212ACA4", Offset = "0x212ACA4", VA = "0x7BBC92ACA4")]
			public void MambetDidUpdateCurrentlyStreamingNotification()
			{
			}

			// Token: 0x060037C0 RID: 14272 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60037C0")]
			[Address(RVA = "0x212AD98", Offset = "0x212AD98", VA = "0x7BBC92AD98")]
			public void onConnectChanged(string connectedStr)
			{
			}

			// Token: 0x060037C1 RID: 14273 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60037C1")]
			[Address(RVA = "0x212AE60", Offset = "0x212AE60", VA = "0x7BBC92AE60")]
			public void onMicFocusChanged(string micFocusedStr)
			{
			}

			// Token: 0x060037C2 RID: 14274 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60037C2")]
			[Address(RVA = "0x212AF28", Offset = "0x212AF28", VA = "0x7BBC92AF28")]
			public void UnityAudioDataSent(string adsStr)
			{
			}

			// Token: 0x060037C3 RID: 14275 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60037C3")]
			[Address(RVA = "0x212B13C", Offset = "0x212B13C", VA = "0x7BBC92B13C")]
			public void ExternalAudioDataSent(string adsStr)
			{
			}

			// Token: 0x060037C4 RID: 14276 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60037C4")]
			[Address(RVA = "0x212B350", Offset = "0x212B350", VA = "0x7BBC92B350")]
			public MambetHandler()
			{
			}

			// Token: 0x04004A2B RID: 18987
			[Token(Token = "0x4004A2B")]
			[FieldOffset(Offset = "0x18")]
			public bool _ApplicationPaused;

			// Token: 0x04004A2C RID: 18988
			[Token(Token = "0x4004A2C")]
			[FieldOffset(Offset = "0x19")]
			public bool _ApplicationQuitting;

			// Token: 0x02000F31 RID: 3889
			[Token(Token = "0x2000F31")]
			[Serializable]
			public class AudioDataSent
			{
				// Token: 0x060037C5 RID: 14277 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60037C5")]
				[Address(RVA = "0x212B818", Offset = "0x212B818", VA = "0x7BBC92B818")]
				public AudioDataSent()
				{
				}

				// Token: 0x04004A2D RID: 18989
				[Token(Token = "0x4004A2D")]
				[FieldOffset(Offset = "0x10")]
				public int id;

				// Token: 0x04004A2E RID: 18990
				[Token(Token = "0x4004A2E")]
				[FieldOffset(Offset = "0x14")]
				public int length;
			}

			// Token: 0x02000F32 RID: 3890
			[Token(Token = "0x2000F32")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA440", Offset = "0x10EA440")]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x060037C7 RID: 14279 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60037C7")]
				[Address(RVA = "0x212B3BC", Offset = "0x212B3BC", VA = "0x7BBC92B3BC")]
				public <>c()
				{
				}

				// Token: 0x060037C8 RID: 14280 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60037C8")]
				[Address(RVA = "0x212B3C4", Offset = "0x212B3C4", VA = "0x7BBC92B3C4")]
				internal void <MambetDidUpdateCurrentlyStreamingNotification>b__4_0()
				{
				}

				// Token: 0x04004A2F RID: 18991
				[Token(Token = "0x4004A2F")]
				[FieldOffset(Offset = "0x0")]
				public static readonly Mambet.MambetHandler.<>c <>9;

				// Token: 0x04004A30 RID: 18992
				[Token(Token = "0x4004A30")]
				[FieldOffset(Offset = "0x8")]
				public static Action <>9__4_0;
			}

			// Token: 0x02000F33 RID: 3891
			[Token(Token = "0x2000F33")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA450", Offset = "0x10EA450")]
			private sealed class <>c__DisplayClass5_0
			{
				// Token: 0x060037C9 RID: 14281 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60037C9")]
				[Address(RVA = "0x212AE58", Offset = "0x212AE58", VA = "0x7BBC92AE58")]
				public <>c__DisplayClass5_0()
				{
				}

				// Token: 0x060037CA RID: 14282 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60037CA")]
				[Address(RVA = "0x212B4B8", Offset = "0x212B4B8", VA = "0x7BBC92B4B8")]
				internal void <onConnectChanged>b__0()
				{
				}

				// Token: 0x04004A31 RID: 18993
				[Token(Token = "0x4004A31")]
				[FieldOffset(Offset = "0x10")]
				public string connectedStr;
			}

			// Token: 0x02000F34 RID: 3892
			[Token(Token = "0x2000F34")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA460", Offset = "0x10EA460")]
			private sealed class <>c__DisplayClass6_0
			{
				// Token: 0x060037CB RID: 14283 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60037CB")]
				[Address(RVA = "0x212AF20", Offset = "0x212AF20", VA = "0x7BBC92AF20")]
				public <>c__DisplayClass6_0()
				{
				}

				// Token: 0x060037CC RID: 14284 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60037CC")]
				[Address(RVA = "0x212B668", Offset = "0x212B668", VA = "0x7BBC92B668")]
				internal void <onMicFocusChanged>b__0()
				{
				}

				// Token: 0x04004A32 RID: 18994
				[Token(Token = "0x4004A32")]
				[FieldOffset(Offset = "0x10")]
				public string micFocusedStr;
			}
		}

		// Token: 0x02000F35 RID: 3893
		[Token(Token = "0x2000F35")]
		public enum ExternalAudioChannel
		{
			// Token: 0x04004A34 RID: 18996
			[Token(Token = "0x4004A34")]
			Mic,
			// Token: 0x04004A35 RID: 18997
			[Token(Token = "0x4004A35")]
			Remote,
			// Token: 0x04004A36 RID: 18998
			[Token(Token = "0x4004A36")]
			Mixed
		}
	}
}
