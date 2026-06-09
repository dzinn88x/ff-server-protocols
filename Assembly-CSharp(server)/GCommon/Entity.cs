using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000EF4 RID: 3828
	[Token(Token = "0x2000EF4")]
	public class Entity : MonoBehaviour, IEntityTicker
	{
		// Token: 0x0600357F RID: 13695 RVA: 0x000101E8 File Offset: 0x0000E3E8
		[Token(Token = "0x600357F")]
		[Address(RVA = "0x2111680", Offset = "0x2111680", VA = "0x7BBC911680")]
		private static uint GetUniqueID()
		{
			return 0U;
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06003580 RID: 13696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006AF")]
		public Transform CachedTransform
		{
			[Token(Token = "0x6003580")]
			[Address(RVA = "0x21116F0", Offset = "0x21116F0", VA = "0x7BBC9116F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06003581 RID: 13697 RVA: 0x00010200 File Offset: 0x0000E400
		// (set) Token: 0x06003582 RID: 13698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006B0")]
		public Vector3 Position
		{
			[Token(Token = "0x6003581")]
			[Address(RVA = "0x2111780", Offset = "0x2111780", VA = "0x7BBC911780", Slot = "9")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6003582")]
			[Address(RVA = "0x21117B0", Offset = "0x21117B0", VA = "0x7BBC9117B0")]
			set
			{
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06003583 RID: 13699 RVA: 0x00010218 File Offset: 0x0000E418
		// (set) Token: 0x06003584 RID: 13700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006B1")]
		public Vector3 Forward
		{
			[Token(Token = "0x6003583")]
			[Address(RVA = "0x2111808", Offset = "0x2111808", VA = "0x7BBC911808")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6003584")]
			[Address(RVA = "0x2111838", Offset = "0x2111838", VA = "0x7BBC911838")]
			set
			{
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06003585 RID: 13701 RVA: 0x00010230 File Offset: 0x0000E430
		// (set) Token: 0x06003586 RID: 13702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006B2")]
		public Vector3 Right
		{
			[Token(Token = "0x6003585")]
			[Address(RVA = "0x2111890", Offset = "0x2111890", VA = "0x7BBC911890")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6003586")]
			[Address(RVA = "0x21118C0", Offset = "0x21118C0", VA = "0x7BBC9118C0")]
			set
			{
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06003587 RID: 13703 RVA: 0x00010248 File Offset: 0x0000E448
		// (set) Token: 0x06003588 RID: 13704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006B3")]
		public Vector3 Up
		{
			[Token(Token = "0x6003587")]
			[Address(RVA = "0x2111918", Offset = "0x2111918", VA = "0x7BBC911918")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6003588")]
			[Address(RVA = "0x2111948", Offset = "0x2111948", VA = "0x7BBC911948")]
			set
			{
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06003589 RID: 13705 RVA: 0x00010260 File Offset: 0x0000E460
		// (set) Token: 0x0600358A RID: 13706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006B4")]
		public Quaternion Rotation
		{
			[Token(Token = "0x6003589")]
			[Address(RVA = "0x21119A0", Offset = "0x21119A0", VA = "0x7BBC9119A0", Slot = "10")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600358A")]
			[Address(RVA = "0x21119D0", Offset = "0x21119D0", VA = "0x7BBC9119D0")]
			set
			{
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x0600358B RID: 13707 RVA: 0x00010278 File Offset: 0x0000E478
		[Token(Token = "0x170006B5")]
		public uint UniqueID
		{
			[Token(Token = "0x600358B")]
			[Address(RVA = "0x2111A30", Offset = "0x2111A30", VA = "0x7BBC911A30")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x0600358C RID: 13708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600358C")]
		[Address(RVA = "0x2111A38", Offset = "0x2111A38", VA = "0x7BBC911A38")]
		public void SetNeedStreamerUpdate(bool v)
		{
		}

		// Token: 0x0600358D RID: 13709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600358D")]
		[Address(RVA = "0x2111BC0", Offset = "0x2111BC0", VA = "0x7BBC911BC0")]
		private void Awake()
		{
		}

		// Token: 0x0600358E RID: 13710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600358E")]
		[Address(RVA = "0x2111C34", Offset = "0x2111C34", VA = "0x7BBC911C34")]
		private void Start()
		{
		}

		// Token: 0x0600358F RID: 13711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600358F")]
		[Address(RVA = "0x2111CBC", Offset = "0x2111CBC", VA = "0x7BBC911CBC")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003590 RID: 13712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003590")]
		[Address(RVA = "0x2111A4C", Offset = "0x2111A4C", VA = "0x7BBC911A4C")]
		public void RegisterVisibleHandler()
		{
		}

		// Token: 0x06003591 RID: 13713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003591")]
		[Address(RVA = "0x2111B08", Offset = "0x2111B08", VA = "0x7BBC911B08")]
		public void UnregisterVisibleHandler()
		{
		}

		// Token: 0x06003592 RID: 13714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003592")]
		[Address(RVA = "0x2111D3C", Offset = "0x2111D3C", VA = "0x7BBC911D3C", Slot = "11")]
		protected virtual void OnAwake()
		{
		}

		// Token: 0x06003593 RID: 13715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003593")]
		[Address(RVA = "0x2111D40", Offset = "0x2111D40", VA = "0x7BBC911D40", Slot = "12")]
		protected virtual void OnStart()
		{
		}

		// Token: 0x06003594 RID: 13716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003594")]
		[Address(RVA = "0x2111D44", Offset = "0x2111D44", VA = "0x7BBC911D44", Slot = "13")]
		protected virtual void OnOnDestroy()
		{
		}

		// Token: 0x06003595 RID: 13717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003595")]
		[Address(RVA = "0x2111D48", Offset = "0x2111D48", VA = "0x7BBC911D48", Slot = "14")]
		public virtual void OnFixedUpdate(float gameTime, float deltaTime)
		{
		}

		// Token: 0x06003596 RID: 13718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003596")]
		[Address(RVA = "0x2111D4C", Offset = "0x2111D4C", VA = "0x7BBC911D4C", Slot = "15")]
		public virtual void OnUpdate(float gameTime, float deltaTime)
		{
		}

		// Token: 0x06003597 RID: 13719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003597")]
		[Address(RVA = "0x2111D50", Offset = "0x2111D50", VA = "0x7BBC911D50", Slot = "16")]
		public virtual void OnPaused()
		{
		}

		// Token: 0x06003598 RID: 13720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003598")]
		[Address(RVA = "0x2111D54", Offset = "0x2111D54", VA = "0x7BBC911D54", Slot = "17")]
		public virtual void OnResumed()
		{
		}

		// Token: 0x06003599 RID: 13721 RVA: 0x00010290 File Offset: 0x0000E490
		[Token(Token = "0x6003599")]
		[Address(RVA = "0x2111D58", Offset = "0x2111D58", VA = "0x7BBC911D58")]
		public bool IsAutonomousProxy()
		{
			return default(bool);
		}

		// Token: 0x0600359A RID: 13722 RVA: 0x000102A8 File Offset: 0x0000E4A8
		[Token(Token = "0x600359A")]
		[Address(RVA = "0x2111D68", Offset = "0x2111D68", VA = "0x7BBC911D68")]
		public bool IsSimulatedProxy()
		{
			return default(bool);
		}

		// Token: 0x0600359B RID: 13723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600359B")]
		[Address(RVA = "0x2111D78", Offset = "0x2111D78", VA = "0x7BBC911D78")]
		public void SetAutonomousProxy()
		{
		}

		// Token: 0x0600359C RID: 13724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600359C")]
		[Address(RVA = "0x2111D80", Offset = "0x2111D80", VA = "0x7BBC911D80")]
		public void SetSimulatedProxy()
		{
		}

		// Token: 0x0600359D RID: 13725 RVA: 0x000102C0 File Offset: 0x0000E4C0
		[Token(Token = "0x600359D")]
		[Address(RVA = "0x2111D8C", Offset = "0x2111D8C", VA = "0x7BBC911D8C")]
		public float GetMaxBoundsExtent()
		{
			return 0f;
		}

		// Token: 0x0600359E RID: 13726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600359E")]
		[Address(RVA = "0x2111E7C", Offset = "0x2111E7C", VA = "0x7BBC911E7C")]
		public Transform FindTransformByName(string name)
		{
			return null;
		}

		// Token: 0x0600359F RID: 13727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600359F")]
		[Address(RVA = "0x2111EA4", Offset = "0x2111EA4", VA = "0x7BBC911EA4")]
		public Transform FindTransformByName(Transform root, string name)
		{
			return null;
		}

		// Token: 0x060035A0 RID: 13728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035A0")]
		[Address(RVA = "0x2112024", Offset = "0x2112024", VA = "0x7BBC912024")]
		public static Transform FindTransformByName(GameObject go, string name)
		{
			return null;
		}

		// Token: 0x060035A1 RID: 13729 RVA: 0x000102D8 File Offset: 0x0000E4D8
		[Token(Token = "0x60035A1")]
		[Address(RVA = "0x21121BC", Offset = "0x21121BC", VA = "0x7BBC9121BC")]
		public static Bounds GetMaxBounds(Transform obj)
		{
			return default(Bounds);
		}

		// Token: 0x060035A2 RID: 13730 RVA: 0x000102F0 File Offset: 0x0000E4F0
		[Token(Token = "0x60035A2")]
		[Address(RVA = "0x2112314", Offset = "0x2112314", VA = "0x7BBC912314")]
		public static float GetMaxBoundsExtent(Bounds bounds)
		{
			return 0f;
		}

		// Token: 0x060035A3 RID: 13731 RVA: 0x00010308 File Offset: 0x0000E508
		[Token(Token = "0x60035A3")]
		[Address(RVA = "0x2111E00", Offset = "0x2111E00", VA = "0x7BBC911E00")]
		public static float GetMaxBoundsExtent(Transform obj)
		{
			return 0f;
		}

		// Token: 0x060035A4 RID: 13732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035A4")]
		[Address(RVA = "0x2112434", Offset = "0x2112434", VA = "0x7BBC912434", Slot = "18")]
		protected virtual void UpdateVisibleStateByStreamer(Vector3 min, Vector3 max)
		{
		}

		// Token: 0x060035A5 RID: 13733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035A5")]
		[Address(RVA = "0x211252C", Offset = "0x211252C", VA = "0x7BBC91252C", Slot = "19")]
		protected virtual void OnUpdateVisibleStateByStreamer(Vector3 min, Vector3 max)
		{
		}

		// Token: 0x060035A6 RID: 13734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035A6")]
		[Address(RVA = "0x2112608", Offset = "0x2112608", VA = "0x7BBC912608")]
		public Entity()
		{
		}

		// Token: 0x040048C4 RID: 18628
		[Token(Token = "0x40048C4")]
		[FieldOffset(Offset = "0x0")]
		public static uint sUniqueEntityID;

		// Token: 0x040048C5 RID: 18629
		[Token(Token = "0x40048C5")]
		[FieldOffset(Offset = "0x18")]
		public bool NeedUpdate;

		// Token: 0x040048C6 RID: 18630
		[Token(Token = "0x40048C6")]
		[FieldOffset(Offset = "0x19")]
		public bool NeedStreamerUpdate;

		// Token: 0x040048C7 RID: 18631
		[Token(Token = "0x40048C7")]
		[FieldOffset(Offset = "0x1A")]
		private bool m_VisibleHandlerRegistered;

		// Token: 0x040048C8 RID: 18632
		[Token(Token = "0x40048C8")]
		[FieldOffset(Offset = "0x20")]
		private Transform m_CachedTransform;

		// Token: 0x040048C9 RID: 18633
		[Token(Token = "0x40048C9")]
		[FieldOffset(Offset = "0x28")]
		private uint m_UniqueID;

		// Token: 0x040048CA RID: 18634
		[Token(Token = "0x40048CA")]
		[FieldOffset(Offset = "0x2C")]
		protected EEntityProxyType m_ProxyType;
	}
}
