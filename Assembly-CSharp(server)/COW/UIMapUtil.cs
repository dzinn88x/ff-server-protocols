using System;
using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C5E RID: 7262
	[Token(Token = "0x2001C5E")]
	public class UIMapUtil
	{
		// Token: 0x06009E18 RID: 40472 RVA: 0x00029580 File Offset: 0x00027780
		[Token(Token = "0x6009E18")]
		[Address(RVA = "0x146E6DC", Offset = "0x146E6DC", VA = "0x7BBBC6E6DC")]
		public static uint GetNamePlateColor(byte teamId)
		{
			return 0U;
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06009E19 RID: 40473 RVA: 0x00029598 File Offset: 0x00027798
		[Token(Token = "0x17000A6F")]
		private static Vector4 CurrentMapOffset
		{
			[Token(Token = "0x6009E19")]
			[Address(RVA = "0x146E818", Offset = "0x146E818", VA = "0x7BBBC6E818")]
			get
			{
				return default(Vector4);
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06009E1A RID: 40474 RVA: 0x000295B0 File Offset: 0x000277B0
		[Token(Token = "0x17000A70")]
		public static float MIN_OFFSET_X
		{
			[Token(Token = "0x6009E1A")]
			[Address(RVA = "0x146E980", Offset = "0x146E980", VA = "0x7BBBC6E980")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06009E1B RID: 40475 RVA: 0x000295C8 File Offset: 0x000277C8
		[Token(Token = "0x17000A71")]
		public static float MAX_OFFSET_X
		{
			[Token(Token = "0x6009E1B")]
			[Address(RVA = "0x146E9DC", Offset = "0x146E9DC", VA = "0x7BBBC6E9DC")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06009E1C RID: 40476 RVA: 0x000295E0 File Offset: 0x000277E0
		[Token(Token = "0x17000A72")]
		public static float MIN_OFFSET_Z
		{
			[Token(Token = "0x6009E1C")]
			[Address(RVA = "0x146EA40", Offset = "0x146EA40", VA = "0x7BBBC6EA40")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06009E1D RID: 40477 RVA: 0x000295F8 File Offset: 0x000277F8
		[Token(Token = "0x17000A73")]
		public static float MAX_OFFSET_Z
		{
			[Token(Token = "0x6009E1D")]
			[Address(RVA = "0x146EAA4", Offset = "0x146EAA4", VA = "0x7BBBC6EAA4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06009E1E RID: 40478 RVA: 0x00029610 File Offset: 0x00027810
		[Token(Token = "0x17000A74")]
		private static float ZONE_DIAMETER
		{
			[Token(Token = "0x6009E1E")]
			[Address(RVA = "0x146EB08", Offset = "0x146EB08", VA = "0x7BBBC6EB08")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06009E1F RID: 40479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E1F")]
		[Address(RVA = "0x146EB7C", Offset = "0x146EB7C", VA = "0x7BBBC6EB7C")]
		public static void InitMapOffsetScaleRatio(float scale)
		{
		}

		// Token: 0x06009E20 RID: 40480 RVA: 0x00029628 File Offset: 0x00027828
		[Token(Token = "0x6009E20")]
		[Address(RVA = "0x146EBF0", Offset = "0x146EBF0", VA = "0x7BBBC6EBF0")]
		public static Vector2 ProjectToMapOffset(Vector2 pos2D)
		{
			return default(Vector2);
		}

		// Token: 0x06009E21 RID: 40481 RVA: 0x00029640 File Offset: 0x00027840
		[Token(Token = "0x6009E21")]
		[Address(RVA = "0x146EE94", Offset = "0x146EE94", VA = "0x7BBBC6EE94")]
		public static float ProjectToMapRadius(float radius)
		{
			return 0f;
		}

		// Token: 0x06009E22 RID: 40482 RVA: 0x00029658 File Offset: 0x00027858
		[Token(Token = "0x6009E22")]
		[Address(RVA = "0x146EF1C", Offset = "0x146EF1C", VA = "0x7BBBC6EF1C")]
		public static Vector3 ProjectToWorldOffset(Vector2 pos2D)
		{
			return default(Vector3);
		}

		// Token: 0x06009E23 RID: 40483 RVA: 0x00029670 File Offset: 0x00027870
		[Token(Token = "0x6009E23")]
		[Address(RVA = "0x146F020", Offset = "0x146F020", VA = "0x7BBBC6F020")]
		public static Vector2 ProjectToMapOffsetUnlimited(Vector2 pos2D)
		{
			return default(Vector2);
		}

		// Token: 0x06009E24 RID: 40484 RVA: 0x00029688 File Offset: 0x00027888
		[Token(Token = "0x6009E24")]
		[Address(RVA = "0x146F124", Offset = "0x146F124", VA = "0x7BBBC6F124")]
		public static Vector2 ProjectToUVPos(Vector2 pos2D)
		{
			return default(Vector2);
		}

		// Token: 0x06009E25 RID: 40485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E25")]
		[Address(RVA = "0x146F248", Offset = "0x146F248", VA = "0x7BBBC6F248")]
		private static void DrawInnerBorder(UITexture circle, SafeZone currentSafeZone)
		{
		}

		// Token: 0x06009E26 RID: 40486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E26")]
		[Address(RVA = "0x146FAC8", Offset = "0x146FAC8", VA = "0x7BBBC6FAC8")]
		public static void DrawInnerCircleZone(UITexture circle, Vector3 pos, float radius)
		{
		}

		// Token: 0x06009E27 RID: 40487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E27")]
		[Address(RVA = "0x146F910", Offset = "0x146F910", VA = "0x7BBBC6F910")]
		public static void DrawInnerDottedCircleZone(UITexture circle, Vector3 pos, float radius)
		{
		}

		// Token: 0x06009E28 RID: 40488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E28")]
		[Address(RVA = "0x146F710", Offset = "0x146F710", VA = "0x7BBBC6F710")]
		internal static void DrawInnerRectZone(UITexture circle, Vector3 pos, float width, float length, Vector3 forward)
		{
		}

		// Token: 0x06009E29 RID: 40489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E29")]
		[Address(RVA = "0x146FC80", Offset = "0x146FC80", VA = "0x7BBBC6FC80")]
		internal static void UpdateInnerCircleMaterial(Material material, Vector3 pos, float radius)
		{
		}

		// Token: 0x06009E2A RID: 40490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E2A")]
		[Address(RVA = "0x14704BC", Offset = "0x14704BC", VA = "0x7BBBC704BC")]
		internal static void UpdateNextCircleMaterial(Material material, Vector3 pos, float radius)
		{
		}

		// Token: 0x06009E2B RID: 40491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E2B")]
		[Address(RVA = "0x146FD30", Offset = "0x146FD30", VA = "0x7BBBC6FD30")]
		internal static void UpdateInnerDottedCircleMaterial(Material material, Vector3 pos, float radius)
		{
		}

		// Token: 0x06009E2C RID: 40492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E2C")]
		[Address(RVA = "0x146FDE0", Offset = "0x146FDE0", VA = "0x7BBBC6FDE0")]
		private static void UpdateInnerRectMaterial(Material material, Vector3 pos, float length, float width, Vector3 forward)
		{
		}

		// Token: 0x06009E2D RID: 40493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E2D")]
		[Address(RVA = "0x146FEC4", Offset = "0x146FEC4", VA = "0x7BBBC6FEC4")]
		private static void UpdateMaterialCenterPos(Material material, UIMapUtil.ESafezoneType type, Vector3 pos)
		{
		}

		// Token: 0x06009E2E RID: 40494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E2E")]
		[Address(RVA = "0x14700B4", Offset = "0x14700B4", VA = "0x7BBBC700B4")]
		private static void UpdateMaterialCircleRadius(Material mat, UIMapUtil.ESafezoneType type, float radius, float lineWidth)
		{
		}

		// Token: 0x06009E2F RID: 40495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E2F")]
		[Address(RVA = "0x147056C", Offset = "0x147056C", VA = "0x7BBBC7056C")]
		private static void UpdateMaterialRectCommon(Material material, UIMapUtil.ESafezoneType type, Vector3 pos, float length, float width, Vector3 forward, float lineWidth)
		{
		}

		// Token: 0x06009E30 RID: 40496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E30")]
		[Address(RVA = "0x1470804", Offset = "0x1470804", VA = "0x7BBBC70804")]
		private static void DrawOuterBorder(UITexture circle, SafeZone currentSafeZone, Vector4 color)
		{
		}

		// Token: 0x06009E31 RID: 40497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E31")]
		[Address(RVA = "0x1470F40", Offset = "0x1470F40", VA = "0x7BBBC70F40")]
		public static void DrawOuterCircleZone(UITexture circle, Vector3 pos, float radius, Vector4 color, bool isDirty = false)
		{
		}

		// Token: 0x06009E32 RID: 40498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E32")]
		[Address(RVA = "0x1470D28", Offset = "0x1470D28", VA = "0x7BBBC70D28")]
		internal static void DrawOuterRectZone(UITexture circle, Vector4 color, Vector3 pos, float width, float length, Vector3 forward)
		{
		}

		// Token: 0x06009E33 RID: 40499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E33")]
		[Address(RVA = "0x1471140", Offset = "0x1471140", VA = "0x7BBBC71140")]
		internal static void UpdateOuterCircleMaterial(Material material, Vector3 pos, float radius, Vector4 color)
		{
		}

		// Token: 0x06009E34 RID: 40500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E34")]
		[Address(RVA = "0x1471228", Offset = "0x1471228", VA = "0x7BBBC71228")]
		private static void UpdateOuterRectMaterial(Material material, Vector3 pos, Vector4 color, float length, float width, Vector3 forward)
		{
		}

		// Token: 0x06009E35 RID: 40501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E35")]
		[Address(RVA = "0x1471330", Offset = "0x1471330", VA = "0x7BBBC71330")]
		private static void UpdateOuterMaterialColor(Material material, Vector4 color)
		{
		}

		// Token: 0x06009E36 RID: 40502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E36")]
		[Address(RVA = "0x14713C0", Offset = "0x14713C0", VA = "0x7BBBC713C0")]
		public static void ResetCachedData(bool excludeNextCircle = false)
		{
		}

		// Token: 0x06009E37 RID: 40503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E37")]
		[Address(RVA = "0x1471560", Offset = "0x1471560", VA = "0x7BBBC71560")]
		internal static void DisableSafezone(SafeZone currentSafeZone, UITexture map)
		{
		}

		// Token: 0x06009E38 RID: 40504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E38")]
		[Address(RVA = "0x1471C98", Offset = "0x1471C98", VA = "0x7BBBC71C98")]
		public static void SetSafeZoneInvisible(UITexture map, UIMapUtil.ESafezoneType type)
		{
		}

		// Token: 0x06009E39 RID: 40505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E39")]
		[Address(RVA = "0x14717C0", Offset = "0x14717C0", VA = "0x7BBBC717C0")]
		public static void SetCircleSafezone(UITexture map)
		{
		}

		// Token: 0x06009E3A RID: 40506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E3A")]
		[Address(RVA = "0x1471A54", Offset = "0x1471A54", VA = "0x7BBBC71A54")]
		public static void SetRectangleSafezone(UITexture map)
		{
		}

		// Token: 0x06009E3B RID: 40507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E3B")]
		[Address(RVA = "0x1471F1C", Offset = "0x1471F1C", VA = "0x7BBBC71F1C")]
		internal static void UpdateSafeZone(SafeZone currentSafeZone, UITexture map)
		{
		}

		// Token: 0x06009E3C RID: 40508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E3C")]
		[Address(RVA = "0x14725D4", Offset = "0x14725D4", VA = "0x7BBBC725D4")]
		public static void DrawCellGameUICircle(UITexture circle, Vector3 center, float radius)
		{
		}

		// Token: 0x06009E3D RID: 40509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E3D")]
		[Address(RVA = "0x14727D8", Offset = "0x14727D8", VA = "0x7BBBC727D8")]
		private static void UpdateCellGameUICircle(Material material, Vector3 pos, float radius, Vector4 color)
		{
		}

		// Token: 0x06009E3E RID: 40510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E3E")]
		[Address(RVA = "0x14729B8", Offset = "0x14729B8", VA = "0x7BBBC729B8")]
		public static void DrawCellGameCircleRing(UITexture circle, Vector3 center, float radius, float lineWidth)
		{
		}

		// Token: 0x06009E3F RID: 40511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E3F")]
		[Address(RVA = "0x1472BB4", Offset = "0x1472BB4", VA = "0x7BBBC72BB4")]
		private static void UpdateCellGameCircleRing(Material material, Vector3 pos, float radius, float lineWidthOff)
		{
		}

		// Token: 0x06009E40 RID: 40512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E40")]
		[Address(RVA = "0x1472450", Offset = "0x1472450", VA = "0x7BBBC72450")]
		private static void UpdateInnerCenterPosScale(SafeZone currentSafeZone)
		{
		}

		// Token: 0x06009E41 RID: 40513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E41")]
		[Address(RVA = "0x1472D78", Offset = "0x1472D78", VA = "0x7BBBC72D78")]
		internal static void UpdateNextSafeZone(SafeZone currentSafeZone, EURl[Qm infoboxData, UITexture nextInnerCircle)
		{
		}

		// Token: 0x06009E42 RID: 40514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E42")]
		[Address(RVA = "0x147324C", Offset = "0x147324C", VA = "0x7BBBC7324C")]
		internal static void UpdateGuideToSaveZone(SafeZone currentSafeZone, UISprite guideToSaveZone, Vector3 playerPos)
		{
		}

		// Token: 0x06009E43 RID: 40515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E43")]
		[Address(RVA = "0x1473768", Offset = "0x1473768", VA = "0x7BBBC73768")]
		public static void SetGameObjectActive(GameObject go, bool active)
		{
		}

		// Token: 0x06009E44 RID: 40516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E44")]
		[Address(RVA = "0x14737C8", Offset = "0x14737C8", VA = "0x7BBBC737C8")]
		public static void UpdateBombArea(GameObject bombParent, GameObject bombInstance, List<GameObject> bombAreas)
		{
		}

		// Token: 0x06009E45 RID: 40517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E45")]
		[Address(RVA = "0x1473DAC", Offset = "0x1473DAC", VA = "0x7BBBC73DAC")]
		internal static void SetCSGameZone(SafeZone currentSafeZone, GameObject zoneTemplate, Transform tr)
		{
		}

		// Token: 0x06009E46 RID: 40518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E46")]
		[Address(RVA = "0x14741C4", Offset = "0x14741C4", VA = "0x7BBBC741C4")]
		internal static void SetBombZone(SafeZone currentSafeZone, Dictionary<uint, UIHudBombZoneView> zones)
		{
		}

		// Token: 0x06009E47 RID: 40519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E47")]
		[Address(RVA = "0x147448C", Offset = "0x147448C", VA = "0x7BBBC7448C")]
		public static void SetTeamateSpriteByIndex(TeammateGameObject teamGo, int idx)
		{
		}

		// Token: 0x06009E48 RID: 40520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E48")]
		[Address(RVA = "0x147459C", Offset = "0x147459C", VA = "0x7BBBC7459C")]
		public static void UpdateTeammatePosition(TeammateGameObject teamGo, Vector3 pos, float angle)
		{
		}

		// Token: 0x06009E49 RID: 40521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E49")]
		[Address(RVA = "0x147481C", Offset = "0x147481C", VA = "0x7BBBC7481C")]
		public static void UpdateEnemyPosition(GameObject enemyGo, Vector3 pos, float angle)
		{
		}

		// Token: 0x06009E4A RID: 40522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E4A")]
		[Address(RVA = "0x1474A1C", Offset = "0x1474A1C", VA = "0x7BBBC74A1C")]
		public static void UpdateBombPosition(GameObject bomb, Vector3 pos, float angle)
		{
		}

		// Token: 0x06009E4B RID: 40523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E4B")]
		[Address(RVA = "0x1474B8C", Offset = "0x1474B8C", VA = "0x7BBBC74B8C")]
		public static void UpdateZeppelinPosition(GameObject zeppelin, Vector3 pos)
		{
		}

		// Token: 0x06009E4C RID: 40524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E4C")]
		[Address(RVA = "0x1474CFC", Offset = "0x1474CFC", VA = "0x7BBBC74CFC")]
		public static void UpdateVehiclePosition(GameObject vehicle, Vector3 pos, float angle)
		{
		}

		// Token: 0x06009E4D RID: 40525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E4D")]
		[Address(RVA = "0x1474E6C", Offset = "0x1474E6C", VA = "0x7BBBC74E6C")]
		public static void PlayerStartFiring(GameObject firing)
		{
		}

		// Token: 0x06009E4E RID: 40526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E4E")]
		[Address(RVA = "0x1474F2C", Offset = "0x1474F2C", VA = "0x7BBBC74F2C")]
		public static void PlayerEndFiring(GameObject firing)
		{
		}

		// Token: 0x06009E4F RID: 40527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009E4F")]
		[Address(RVA = "0x147506C", Offset = "0x147506C", VA = "0x7BBBC7506C")]
		public static TeammateGameObject CreateTeammateGameObject(GameObject teammate)
		{
			return null;
		}

		// Token: 0x06009E50 RID: 40528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E50")]
		[Address(RVA = "0x14750D0", Offset = "0x14750D0", VA = "0x7BBBC750D0")]
		public static void SetupAirLine(UISprite airline_start, UISprite airline_end, UISprite airline)
		{
		}

		// Token: 0x06009E51 RID: 40529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E51")]
		[Address(RVA = "0x1475788", Offset = "0x1475788", VA = "0x7BBBC75788")]
		public UIMapUtil()
		{
		}

		// Token: 0x0400A464 RID: 42084
		[Token(Token = "0x400A464")]
		[FieldOffset(Offset = "0x0")]
		public static Dictionary<int, uint> NamePlateColorDict;

		// Token: 0x0400A465 RID: 42085
		[Token(Token = "0x400A465")]
		[FieldOffset(Offset = "0x8")]
		public static Dictionary<int, uint> NamePlateColorDict4CS;

		// Token: 0x0400A466 RID: 42086
		[Token(Token = "0x400A466")]
		[FieldOffset(Offset = "0x10")]
		public static int NAME_PLATE_COLOR_COUNT;

		// Token: 0x0400A467 RID: 42087
		[Token(Token = "0x400A467")]
		[FieldOffset(Offset = "0x14")]
		public static int NAME_PLATE_COLOR_COUNT_CS;

		// Token: 0x0400A468 RID: 42088
		[Token(Token = "0x400A468")]
		[FieldOffset(Offset = "0x18")]
		public static Vector4 DEFAULT_MAP_OFFSET;

		// Token: 0x0400A469 RID: 42089
		[Token(Token = "0x400A469")]
		[FieldOffset(Offset = "0x28")]
		public static Dictionary<uint, Vector4> MAPOFFSET_DICT;

		// Token: 0x0400A46A RID: 42090
		[Token(Token = "0x400A46A")]
		public const float ZONE_DIAMETER_MAP = 1024f;

		// Token: 0x0400A46B RID: 42091
		[Token(Token = "0x400A46B")]
		[FieldOffset(Offset = "0x30")]
		public static float OFFSET_SCALE_RATIO_X;

		// Token: 0x0400A46C RID: 42092
		[Token(Token = "0x400A46C")]
		[FieldOffset(Offset = "0x34")]
		public static float MAP_WIDTH;

		// Token: 0x0400A46D RID: 42093
		[Token(Token = "0x400A46D")]
		[FieldOffset(Offset = "0x38")]
		public static float MAP_DOTTED_WIDTH;

		// Token: 0x0400A46E RID: 42094
		[Token(Token = "0x400A46E")]
		[FieldOffset(Offset = "0x3C")]
		public static float OUTER_LINEWIDTH;

		// Token: 0x0400A46F RID: 42095
		[Token(Token = "0x400A46F")]
		[FieldOffset(Offset = "0x40")]
		public static float MAP_OUTZONE_TRANSPARENCY;

		// Token: 0x0400A470 RID: 42096
		[Token(Token = "0x400A470")]
		[FieldOffset(Offset = "0x44")]
		private static Vector3 m_InnerCenterPos;

		// Token: 0x0400A471 RID: 42097
		[Token(Token = "0x400A471")]
		[FieldOffset(Offset = "0x50")]
		private static Vector3 m_InnerZoneScale;

		// Token: 0x0400A472 RID: 42098
		[Token(Token = "0x400A472")]
		[FieldOffset(Offset = "0x5C")]
		public static Vector4 OUTER_COLOR_BLUE;

		// Token: 0x0400A473 RID: 42099
		[Token(Token = "0x400A473")]
		[FieldOffset(Offset = "0x6C")]
		public static Vector4 OUTER_COLOR_WHITE;

		// Token: 0x0400A474 RID: 42100
		[Token(Token = "0x400A474")]
		[FieldOffset(Offset = "0x7C")]
		public static Vector4 COLOR_CELL_GAME_CIRCLE_BG;

		// Token: 0x0400A475 RID: 42101
		[Token(Token = "0x400A475")]
		[FieldOffset(Offset = "0x8C")]
		public static Vector4 COLOR_CELL_GAME_CIRCLE_RING;

		// Token: 0x0400A476 RID: 42102
		[Token(Token = "0x400A476")]
		[FieldOffset(Offset = "0x9C")]
		private static Vector3 m_CachedInnerCenter;

		// Token: 0x0400A477 RID: 42103
		[Token(Token = "0x400A477")]
		[FieldOffset(Offset = "0xA8")]
		private static float m_CachedInnerRadius;

		// Token: 0x0400A478 RID: 42104
		[Token(Token = "0x400A478")]
		[FieldOffset(Offset = "0xAC")]
		private static float m_CachedInnerWidth;

		// Token: 0x0400A479 RID: 42105
		[Token(Token = "0x400A479")]
		[FieldOffset(Offset = "0xB0")]
		private static float m_CachedInnerLength;

		// Token: 0x0400A47A RID: 42106
		[Token(Token = "0x400A47A")]
		[FieldOffset(Offset = "0xB4")]
		private static Vector3 m_CachedInnerForward;

		// Token: 0x0400A47B RID: 42107
		[Token(Token = "0x400A47B")]
		[FieldOffset(Offset = "0xC0")]
		private static Vector3 m_CachedOuterCenter;

		// Token: 0x0400A47C RID: 42108
		[Token(Token = "0x400A47C")]
		[FieldOffset(Offset = "0xCC")]
		private static float m_CachedOuterRadius;

		// Token: 0x0400A47D RID: 42109
		[Token(Token = "0x400A47D")]
		[FieldOffset(Offset = "0xD0")]
		private static float m_CachedOuterWidth;

		// Token: 0x0400A47E RID: 42110
		[Token(Token = "0x400A47E")]
		[FieldOffset(Offset = "0xD4")]
		private static float m_CachedOuterLength;

		// Token: 0x0400A47F RID: 42111
		[Token(Token = "0x400A47F")]
		[FieldOffset(Offset = "0xD8")]
		private static Vector3 m_CachedOuterForward;

		// Token: 0x0400A480 RID: 42112
		[Token(Token = "0x400A480")]
		[FieldOffset(Offset = "0xE4")]
		private static Vector4 m_CachedOuterColor;

		// Token: 0x0400A481 RID: 42113
		[Token(Token = "0x400A481")]
		[FieldOffset(Offset = "0xF4")]
		private static Vector4 m_CachedShaderOuterInnerCenter;

		// Token: 0x0400A482 RID: 42114
		[Token(Token = "0x400A482")]
		[FieldOffset(Offset = "0x104")]
		private static Vector4 m_CachedShaderRadii;

		// Token: 0x0400A483 RID: 42115
		[Token(Token = "0x400A483")]
		[FieldOffset(Offset = "0x114")]
		private static Vector4 m_CachedShaderLineWidth;

		// Token: 0x0400A484 RID: 42116
		[Token(Token = "0x400A484")]
		public const string DEFAULT_MAP_RES_NAME = "minimap";

		// Token: 0x0400A485 RID: 42117
		[Token(Token = "0x400A485")]
		[FieldOffset(Offset = "0x128")]
		private static Dictionary<int, string> m_TeamSpritesDict;

		// Token: 0x02001C5F RID: 7263
		[Token(Token = "0x2001C5F")]
		public enum EMapType
		{
			// Token: 0x0400A487 RID: 42119
			[Token(Token = "0x400A487")]
			Minimap,
			// Token: 0x0400A488 RID: 42120
			[Token(Token = "0x400A488")]
			Bigmap,
			// Token: 0x0400A489 RID: 42121
			[Token(Token = "0x400A489")]
			Sidemap
		}

		// Token: 0x02001C60 RID: 7264
		[Token(Token = "0x2001C60")]
		public enum ESafezoneType
		{
			// Token: 0x0400A48B RID: 42123
			[Token(Token = "0x400A48B")]
			Outer,
			// Token: 0x0400A48C RID: 42124
			[Token(Token = "0x400A48C")]
			Inner,
			// Token: 0x0400A48D RID: 42125
			[Token(Token = "0x400A48D")]
			Next,
			// Token: 0x0400A48E RID: 42126
			[Token(Token = "0x400A48E")]
			InnerDotted
		}
	}
}
