using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020012A2 RID: 4770
	[Token(Token = "0x20012A2")]
	public class PreviewStoryCgComp : MonoBehaviour
	{
		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06004A9D RID: 19101 RVA: 0x00016800 File Offset: 0x00014A00
		[Token(Token = "0x1700083F")]
		public uint CurrentType
		{
			[Token(Token = "0x6004A9D")]
			[Address(RVA = "0x174A510", Offset = "0x174A510", VA = "0x7BBBF4A510")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06004A9E RID: 19102 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004A9F RID: 19103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000840")]
		public Camera CurrentCGCamera
		{
			[Token(Token = "0x6004A9E")]
			[Address(RVA = "0x174A518", Offset = "0x174A518", VA = "0x7BBBF4A518")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A9F")]
			[Address(RVA = "0x174A520", Offset = "0x174A520", VA = "0x7BBBF4A520")]
			set
			{
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06004AA0 RID: 19104 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004AA1 RID: 19105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000841")]
		public GameObject CurrentCG
		{
			[Token(Token = "0x6004AA0")]
			[Address(RVA = "0x174A528", Offset = "0x174A528", VA = "0x7BBBF4A528")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004AA1")]
			[Address(RVA = "0x174A530", Offset = "0x174A530", VA = "0x7BBBF4A530")]
			set
			{
			}
		}

		// Token: 0x06004AA2 RID: 19106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AA2")]
		[Address(RVA = "0x174A538", Offset = "0x174A538", VA = "0x7BBBF4A538")]
		public void SetReturnBtnVisble(bool enabled)
		{
		}

		// Token: 0x06004AA3 RID: 19107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AA3")]
		[Address(RVA = "0x174A588", Offset = "0x174A588", VA = "0x7BBBF4A588")]
		protected void Awake()
		{
		}

		// Token: 0x06004AA4 RID: 19108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AA4")]
		[Address(RVA = "0x174AA08", Offset = "0x174AA08", VA = "0x7BBBF4AA08")]
		public void SetCgCameraEnable(bool enabled)
		{
		}

		// Token: 0x06004AA5 RID: 19109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AA5")]
		[Address(RVA = "0x174AAB8", Offset = "0x174AAB8", VA = "0x7BBBF4AAB8")]
		private void OnbtnReturn()
		{
		}

		// Token: 0x06004AA6 RID: 19110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AA6")]
		[Address(RVA = "0x174AE2C", Offset = "0x174AE2C", VA = "0x7BBBF4AE2C")]
		private void SkipAnim()
		{
		}

		// Token: 0x06004AA7 RID: 19111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AA7")]
		[Address(RVA = "0x174B518", Offset = "0x174B518", VA = "0x7BBBF4B518")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113DC90", Offset = "0x113DC90")]
		private IEnumerator SkipCg()
		{
			return null;
		}

		// Token: 0x06004AA8 RID: 19112 RVA: 0x00016818 File Offset: 0x00014A18
		[Token(Token = "0x6004AA8")]
		[Address(RVA = "0x174B5B8", Offset = "0x174B5B8", VA = "0x7BBBF4B5B8")]
		public bool GetCgInSkip()
		{
			return default(bool);
		}

		// Token: 0x06004AA9 RID: 19113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AA9")]
		[Address(RVA = "0x174B5C0", Offset = "0x174B5C0", VA = "0x7BBBF4B5C0")]
		public void ReplayCg()
		{
		}

		// Token: 0x06004AAA RID: 19114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AAA")]
		[Address(RVA = "0x174A9D4", Offset = "0x174A9D4", VA = "0x7BBBF4A9D4")]
		private void ClearMask()
		{
		}

		// Token: 0x06004AAB RID: 19115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AAB")]
		[Address(RVA = "0x174B960", Offset = "0x174B960", VA = "0x7BBBF4B960")]
		public void InitCgConf(ResourceID cgresid, uint uitype, bool isHas)
		{
		}

		// Token: 0x06004AAC RID: 19116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AAC")]
		[Address(RVA = "0x174C2BC", Offset = "0x174C2BC", VA = "0x7BBBF4C2BC")]
		public void PlaySubtitle(params object[] data)
		{
		}

		// Token: 0x06004AAD RID: 19117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AAD")]
		[Address(RVA = "0x174C4C4", Offset = "0x174C4C4", VA = "0x7BBBF4C4C4")]
		public void StopSubtitle(params object[] data)
		{
		}

		// Token: 0x06004AAE RID: 19118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AAE")]
		[Address(RVA = "0x174AABC", Offset = "0x174AABC", VA = "0x7BBBF4AABC")]
		public void ClearCG()
		{
		}

		// Token: 0x06004AAF RID: 19119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AAF")]
		[Address(RVA = "0x174C208", Offset = "0x174C208", VA = "0x7BBBF4C208")]
		public void PlayCg()
		{
		}

		// Token: 0x06004AB0 RID: 19120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AB0")]
		[Address(RVA = "0x174C5A8", Offset = "0x174C5A8", VA = "0x7BBBF4C5A8")]
		public void StopCg(params object[] data)
		{
		}

		// Token: 0x06004AB1 RID: 19121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AB1")]
		[Address(RVA = "0x174AEDC", Offset = "0x174AEDC", VA = "0x7BBBF4AEDC")]
		private void SetCgMeshEffect(bool enabled)
		{
		}

		// Token: 0x06004AB2 RID: 19122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AB2")]
		[Address(RVA = "0x174B024", Offset = "0x174B024", VA = "0x7BBBF4B024")]
		private void SetPreviewCgSpeed(int speed)
		{
		}

		// Token: 0x06004AB3 RID: 19123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AB3")]
		[Address(RVA = "0x174B7AC", Offset = "0x174B7AC", VA = "0x7BBBF4B7AC")]
		private void ResetParticleSystemSpeed()
		{
		}

		// Token: 0x06004AB4 RID: 19124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AB4")]
		[Address(RVA = "0x174C788", Offset = "0x174C788", VA = "0x7BBBF4C788")]
		public void SetCallBack(Action callback)
		{
		}

		// Token: 0x06004AB5 RID: 19125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AB5")]
		[Address(RVA = "0x174C760", Offset = "0x174C760", VA = "0x7BBBF4C760")]
		private void Executecallback()
		{
		}

		// Token: 0x06004AB6 RID: 19126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AB6")]
		[Address(RVA = "0x174C790", Offset = "0x174C790", VA = "0x7BBBF4C790")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004AB7 RID: 19127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AB7")]
		[Address(RVA = "0x174C95C", Offset = "0x174C95C", VA = "0x7BBBF4C95C")]
		private void StopMusic()
		{
		}

		// Token: 0x06004AB8 RID: 19128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AB8")]
		[Address(RVA = "0x174CA00", Offset = "0x174CA00", VA = "0x7BBBF4CA00")]
		public PreviewStoryCgComp()
		{
		}

		// Token: 0x040072EA RID: 29418
		[Token(Token = "0x40072EA")]
		[FieldOffset(Offset = "0x18")]
		private bool m_CgStart;

		// Token: 0x040072EB RID: 29419
		[Token(Token = "0x40072EB")]
		[FieldOffset(Offset = "0x20")]
		private GameObject m_CurrentCg;

		// Token: 0x040072EC RID: 29420
		[Token(Token = "0x40072EC")]
		[FieldOffset(Offset = "0x28")]
		private Camera m_CurrentCgCamera;

		// Token: 0x040072ED RID: 29421
		[Token(Token = "0x40072ED")]
		[FieldOffset(Offset = "0x30")]
		public Transform CgAnimTrans;

		// Token: 0x040072EE RID: 29422
		[Token(Token = "0x40072EE")]
		[FieldOffset(Offset = "0x38")]
		public Transform CGShowUITrans;

		// Token: 0x040072EF RID: 29423
		[Token(Token = "0x40072EF")]
		[FieldOffset(Offset = "0x40")]
		public GameObject BgMask;

		// Token: 0x040072F0 RID: 29424
		[Token(Token = "0x40072F0")]
		[FieldOffset(Offset = "0x48")]
		public GameObject ShowMask;

		// Token: 0x040072F1 RID: 29425
		[Token(Token = "0x40072F1")]
		[FieldOffset(Offset = "0x50")]
		public UIButton ReturnBtn_LowerLeft;

		// Token: 0x040072F2 RID: 29426
		[Token(Token = "0x40072F2")]
		[FieldOffset(Offset = "0x58")]
		public UIButton ReturnBtn_UpperRight;

		// Token: 0x040072F3 RID: 29427
		[Token(Token = "0x40072F3")]
		[FieldOffset(Offset = "0x60")]
		private UIButton CurrentButton;

		// Token: 0x040072F4 RID: 29428
		[Token(Token = "0x40072F4")]
		[FieldOffset(Offset = "0x68")]
		private PreviewStoryCgShowUIComp m_previewcomp;

		// Token: 0x040072F5 RID: 29429
		[Token(Token = "0x40072F5")]
		[FieldOffset(Offset = "0x70")]
		public UITexture BgPanel;

		// Token: 0x040072F6 RID: 29430
		[Token(Token = "0x40072F6")]
		[FieldOffset(Offset = "0x78")]
		public Camera m_CurrentBgCamera;

		// Token: 0x040072F7 RID: 29431
		[Token(Token = "0x40072F7")]
		[FieldOffset(Offset = "0x80")]
		private Dictionary<ParticleSystem, ParticleSystem.MinMaxCurve> m_CGLoopParticleSystemDelayTable;

		// Token: 0x040072F8 RID: 29432
		[Token(Token = "0x40072F8")]
		[FieldOffset(Offset = "0x88")]
		private uint m_type;

		// Token: 0x040072F9 RID: 29433
		[Token(Token = "0x40072F9")]
		[FieldOffset(Offset = "0x8C")]
		private bool m_IsInSkip;

		// Token: 0x040072FA RID: 29434
		[Token(Token = "0x40072FA")]
		[FieldOffset(Offset = "0x90")]
		private Action m_callback;

		// Token: 0x020012A3 RID: 4771
		[Token(Token = "0x20012A3")]
		public enum FULLCG
		{
			// Token: 0x040072FC RID: 29436
			[Token(Token = "0x40072FC")]
			IceAge = 101,
			// Token: 0x040072FD RID: 29437
			[Token(Token = "0x40072FD")]
			BioManiac,
			// Token: 0x040072FE RID: 29438
			[Token(Token = "0x40072FE")]
			FlyWing
		}

		// Token: 0x020012A4 RID: 4772
		[Token(Token = "0x20012A4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB030", Offset = "0x10EB030")]
		private sealed class <SkipCg>d__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06004AB9 RID: 19129 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004AB9")]
			[Address(RVA = "0x174B58C", Offset = "0x174B58C", VA = "0x7BBBF4B58C")]
			[DebuggerHidden]
			public <SkipCg>d__31(int <>1__state)
			{
			}

			// Token: 0x06004ABA RID: 19130 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004ABA")]
			[Address(RVA = "0x174CA08", Offset = "0x174CA08", VA = "0x7BBBF4CA08", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06004ABB RID: 19131 RVA: 0x00016830 File Offset: 0x00014A30
			[Token(Token = "0x6004ABB")]
			[Address(RVA = "0x174CA0C", Offset = "0x174CA0C", VA = "0x7BBBF4CA0C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000842 RID: 2114
			// (get) Token: 0x06004ABC RID: 19132 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000842")]
			private object Current
			{
				[Token(Token = "0x6004ABC")]
				[Address(RVA = "0x174CAD0", Offset = "0x174CAD0", VA = "0x7BBBF4CAD0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06004ABD RID: 19133 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004ABD")]
			[Address(RVA = "0x174CAD8", Offset = "0x174CAD8", VA = "0x7BBBF4CAD8", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000843 RID: 2115
			// (get) Token: 0x06004ABE RID: 19134 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000843")]
			private object Current
			{
				[Token(Token = "0x6004ABE")]
				[Address(RVA = "0x174CB40", Offset = "0x174CB40", VA = "0x7BBBF4CB40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040072FF RID: 29439
			[Token(Token = "0x40072FF")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04007300 RID: 29440
			[Token(Token = "0x4007300")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04007301 RID: 29441
			[Token(Token = "0x4007301")]
			[FieldOffset(Offset = "0x20")]
			public PreviewStoryCgComp <>4__this;
		}
	}
}
